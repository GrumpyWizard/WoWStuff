#include "CCameraOffsetCalculator.h"


bool CCameraOffsetCalculator::IsValidCameraRole() const
{
  return (mCameraRoles.size() > 0);
}


bool CCameraOffsetCalculator::FindCameraRole(char *pCameraRole)
{
  char tempRole[MAX_SIZE_CAMROLE];
  strncpy(tempRole, pCameraRole, MAX_SIZE_CAMROLE);

  for (std::vector<SCameraOffsetCalculatorRole>::iterator it = mCameraRoles.begin(); it != mCameraRoles.end(); ++it)
  {
    SCameraOffsetCalculatorRole role = *it;
    if (strcmp(role.mCameraRole, tempRole) == 0)
    {
      return true;
    }
  }
  return false;
}


int CCameraOffsetCalculator::SizeCameraRole() const
{
  return mCameraRoles.size();
}




int CCameraOffsetCalculator::SizeOffsetOfCameraRole(char *pCameraRole)
{
  if (!IsValidCameraRole())
    return 0;

  char tempRole[MAX_SIZE_CAMROLE];
  strncpy(tempRole, pCameraRole, MAX_SIZE_CAMROLE);

  for (std::vector<SCameraOffsetCalculatorRole>::iterator it = mCameraRoles.begin(); it != mCameraRoles.end(); ++it)
  {
    SCameraOffsetCalculatorRole role = *it;
    if (strcmp(role.mCameraRole, tempRole) == 0)
    {
      return role.mCameraOffsets.size();
    }
  }
  return 0;
}

char *CCameraOffsetCalculator::GetCameraRoleName(uint32 Index)
{
  if (Index > mCameraRoles.size())
    return NULL;

  return mCameraRoles[Index].mCameraRole;
}


void CCameraOffsetCalculator::AddCameraRole(char *pCameraRole)
{
  SCameraOffsetCalculatorRole CameraRole;
  strncpy(CameraRole.mCameraRole, pCameraRole, MAX_SIZE_CAMROLE);
  mCameraRoles.push_back(CameraRole);
}


void CCameraOffsetCalculator::AddCameraOffsetToRole(char *pCameraRole, int32 pCameraX, int32 pCameraY)
{
  if (!FindCameraRole(pCameraRole))
  {
    AddCameraRole(pCameraRole); // Did not find role with name pCameraRole, creating new one!
  }

  // add coords to camerarole
  char tempRole[MAX_SIZE_CAMROLE];
  strncpy(tempRole, pCameraRole, MAX_SIZE_CAMROLE);
  
  for (int i = 0; i < SizeCameraRole(); i++)
  {
    if (strcmp(mCameraRoles[i].mCameraRole, tempRole) == 0)
    {
      SCameraOffsetCalculatorOffset offset;
      offset.mCameraX = pCameraX;
      offset.mCameraY = pCameraY;
      mCameraRoles[i].mCameraOffsets.push_back(offset);
    }
  }

  //int i = 0;
  //for (std::vector<SCameraOffsetCalculatorRole>::iterator it = mCameraRoles.begin(); it != mCameraRoles.end(); ++it)
  //{
  //  SCameraOffsetCalculatorRole role = *it;
  //  if (strcmp(role.mCameraRole, tempRole) == 0)
  //  {
  //    SCameraOffsetCalculatorOffset offset;
  //    offset.mCameraX = pCameraX;
  //    offset.mCameraY = pCameraY;
  //    mCameraRoles[i].mCameraOffsets.push_back(offset);
  //  }
  //  i++;
  //}  
}


bool CCameraOffsetCalculator::GetCameraOffsetIndexFromRole(size_t OffsetIndex, char *pCameraRole, int32& pCameraX, int32& pCameraY)
{
  if (!IsValidCameraRole())
    return false;

  int offsetSize = SizeOffsetOfCameraRole(pCameraRole);

  if ((OffsetIndex + 1) > offsetSize)
    return false;

  char tempRole[MAX_SIZE_CAMROLE];
  strncpy(tempRole, pCameraRole, MAX_SIZE_CAMROLE);
  
  for (int i = 0; i < SizeCameraRole(); i++)
  {
    if (strcmp(mCameraRoles[i].mCameraRole, tempRole) == 0)
    {
      pCameraX = mCameraRoles[i].mCameraOffsets[OffsetIndex].mCameraX;
      pCameraY = mCameraRoles[i].mCameraOffsets[OffsetIndex].mCameraY;
      return true;
    }
  }

  //int i = 0;
  //for (std::vector<SCameraOffsetCalculatorRole>::iterator it = mCameraRoles.begin(); it != mCameraRoles.end(); ++it)
  //{
  //  SCameraOffsetCalculatorRole role = *it;
  //  if (strcmp(role.mCameraRole, tempRole) == 0)
  //  {
  //    pCameraX = mCameraRoles[i].mCameraOffsets[OffsetIndex].mCameraX;
  //    pCameraY = mCameraRoles[i].mCameraOffsets[OffsetIndex].mCameraY;
  //    return true;
  //  }
  //  i++;
  //}
  return false;
}


void CCameraOffsetCalculator::PrintAll()
{
  int offsetsize = 0;

  for (std::vector<SCameraOffsetCalculatorRole>::iterator it = mCameraRoles.begin(); it != mCameraRoles.end(); ++it)
  {
    SCameraOffsetCalculatorRole role = *it;
    std::cout << role.mCameraRole << "\n";
    int offsetsize = role.mCameraOffsets.size();
    for (int i = 0; i < offsetsize; i++)
    {
      std::cout << "x:" << role.mCameraOffsets[i].mCameraX << " y:" << role.mCameraOffsets[i].mCameraY << "\n";
    }
    std::cout << "\n";
  }
}
