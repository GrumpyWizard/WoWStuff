#include "types.h"
#include "CCameraOffsetCalculator.h"
#include <iostream>


int main()
{
  CCameraOffsetCalculator *CamCalc = new CCameraOffsetCalculator();
  
  char CameraRoleA[MAX_SIZE_CAMROLE];
  char CameraRoleB[MAX_SIZE_CAMROLE];

  strncpy(CameraRoleA, "NIR", MAX_SIZE_CAMROLE);
  strncpy(CameraRoleB, "Color", MAX_SIZE_CAMROLE);

  CamCalc->AddCameraRole(CameraRoleA);
  CamCalc->AddCameraOffsetToRole(CameraRoleA, 0, 0);
  CamCalc->AddCameraOffsetToRole(CameraRoleA, 1, 1);
  CamCalc->AddCameraOffsetToRole(CameraRoleA, 11, 2345);
  CamCalc->AddCameraOffsetToRole(CameraRoleA, -11234, 11);

  CamCalc->AddCameraOffsetToRole(CameraRoleB, 666, 666);
  CamCalc->AddCameraOffsetToRole(CameraRoleB, 76, 67);

  if (CamCalc->FindCameraRole("Pino"))
  {
    std::cout << "Ja!";
  }
  else
  {
    std::cout << "Nee!";
  }

  if (CamCalc->FindCameraRole("NIR"))
  {
    std::cout << "Jaaaa!";
  }
  else
  {
    std::cout << "Neeeeee!";
  }

  CamCalc->PrintAll();

  int a = CamCalc->SizeOffsetOfCameraRole(CameraRoleA);
  int b = CamCalc->SizeOffsetOfCameraRole(CameraRoleB);

  std::cout << a << "\n";
  std::cout << b << "\n\n";
  
  int c = CamCalc->SizeCameraRole();

  for (int j = 0; j < c; j++)
  {
    char tempName[MAX_SIZE_CAMROLE];
    
    strncpy(tempName, CamCalc->GetCameraRoleName(j), MAX_SIZE_CAMROLE);
    std::cout << "name:" << tempName << "\n";
  }

  for (int k = 0; k < CamCalc->SizeCameraRole(); k++)
  {
    int camx, camy;
    for (int l = 0; l < CamCalc->SizeOffsetOfCameraRole(CamCalc->GetCameraRoleName(k)); l++)
    {
      if (CamCalc->GetCameraOffsetIndexFromRole(l, CamCalc->GetCameraRoleName(k), camx, camy))
      {
        std::cout << "camx:" << camx << " camy:" << camy << "\n";
      }
    }
  }

  delete CamCalc;
  
  return 0;
}