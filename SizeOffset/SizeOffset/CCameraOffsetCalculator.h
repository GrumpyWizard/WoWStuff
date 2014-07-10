#ifndef __CAMERA_OFFSET_CALCULATOR_H__
#define __CAMERA_OFFSET_CALCULATOR_H__

#include <iostream>
#include <vector>
#include "types.h"

class CCameraOffsetCalculator
{
  public:
    bool IsValidCameraRole() const;
    //bool IsValidOffsetOfCameraRole() const;
    bool FindCameraRole(char *pCameraRole);

    int SizeCameraRole() const;
    int SizeOffsetOfCameraRole(char *pCameraRole);

    char *GetCameraRoleName(uint32 Index);

    void AddCameraRole(char *pCameraRole);
    void AddCameraOffsetToRole(char *pCameraRole, int32 pCameraX, int32 pCameraY);
    bool GetCameraOffsetIndexFromRole(size_t OffsetIndex, char *pCameraRole, int32& pCameraX, int32& pCameraY);
    void PrintAll();

    template<typename Stream>
    void composite(Stream& stream)
    {
      int32 sizeCameraRole = SizeCameraRole();
      stream.simple(sizeCameraRole);

      if (stream.IsInput())
      {       
        mCameraRoles.resize(sizeCameraRole);
        for (int i = 0; i < sizeCameraRole; i++)
        {
          int32 sizeCameraOffset = SizeOffsetOfCameraRole(GetCameraRoleName(i));
          mCameraRoles[i].mCameraOffsets.resize(sizeCameraOffset);
        }
      }

      for (int j = 0; j < sizeCameraRole; j++)
      {
        stream.simple(mCameraRoles[j].mCameraRole);
        int32 sizeCameraOffset = SizeOffsetOfCameraRole(GetCameraRoleName(j));
        for (int k = 0; k < sizeCameraOffset; k++)
        {
          stream.simple(mCameraRoles[j].mCameraOffsets[k].mCameraX);
          stream.simple(mCameraRoles[j].mCameraOffsets[k].mCameraY);
        }
      }
    }

  private:
    struct SCameraOffsetCalculatorOffset
    {
      SCameraOffsetCalculatorOffset(int32 pCameraX, int32 pCameraY)
        : mCameraX(pCameraX)
        , mCameraY(pCameraY)
      {}
      
      SCameraOffsetCalculatorOffset()
        : mCameraX(0)
        , mCameraY(0)
      {}

      int32 mCameraX;
      int32 mCameraY;
    };

    struct SCameraOffsetCalculatorRole
    {
      SCameraOffsetCalculatorRole(char *pCameraRole)
      {
        strncpy(mCameraRole, pCameraRole, MAX_SIZE_CAMROLE);
        mCameraOffsets.clear();
      }

      SCameraOffsetCalculatorRole()
      {
        memset(mCameraRole, 0, MAX_SIZE_CAMROLE);
        mCameraOffsets.clear();
      }
      
      char mCameraRole[MAX_SIZE_CAMROLE];
      std::vector<SCameraOffsetCalculatorOffset> mCameraOffsets;
    };
    std::vector<SCameraOffsetCalculatorRole> mCameraRoles;
};

#endif