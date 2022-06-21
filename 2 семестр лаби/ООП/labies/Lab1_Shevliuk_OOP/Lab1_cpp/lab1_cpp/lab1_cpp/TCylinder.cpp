#include "TCylinder.h"
#include <iostream>

using namespace std;

TCylinder:: TCylinder()
{
    height = 0;
}

TCylinder::TCylinder(double radius, double height)
{
    SetRadius(radius);
    this->height = height;
}

TCylinder:: TCylinder( const TCylinder& cylinder)
{
    SetRadius(cylinder.GetRadius());
    this->height = cylinder.GetHeight();
}

double TCylinder::GetHeight() const
{
    return height;
}

 double TCylinder::SetHeight(int radius)
{
    return this->height = radius;
}

 double TCylinder::CylinderVolume()
{
    return height * CircleSquare();
}

 void TCylinder::CylinderCompare(TCylinder cylinder)
{
    if (cylinder.CylinderVolume() > CylinderVolume())
    {
        cout<<"������ ���i��� �i����� �� ������!"<<endl;
    }
    else if (cylinder.CylinderVolume() == CylinderVolume())
    {
        cout<<"�i ���i��� �i��i!"<<endl;
    }
    else if (cylinder.CylinderVolume() < CylinderVolume())
    {
       cout<<"������ ���i��� �i����� �� ������!"<<endl;
    }
}

 void TCylinder::CylinderInfo() {
     cout << std::string("���i�� ���i����: ") << GetRadius() << "\n" << "������ ���i����: " << GetHeight() <<
         "\n" << "�ᒺ� ���i����: " <<CylinderVolume() << "\n" << endl;
 }