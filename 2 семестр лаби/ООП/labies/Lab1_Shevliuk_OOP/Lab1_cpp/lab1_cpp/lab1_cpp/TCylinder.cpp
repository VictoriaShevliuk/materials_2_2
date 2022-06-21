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
        cout<<"Другий цилiндр бiльший за перший!"<<endl;
    }
    else if (cylinder.CylinderVolume() == CylinderVolume())
    {
        cout<<"Цi цилiнри рiвнi!"<<endl;
    }
    else if (cylinder.CylinderVolume() < CylinderVolume())
    {
       cout<<"Перший цилiндр бiльший за другий!"<<endl;
    }
}

 void TCylinder::CylinderInfo() {
     cout << std::string("Радiус цилiндра: ") << GetRadius() << "\n" << "Висота цилiндра: " << GetHeight() <<
         "\n" << "Об’єм цилiндра: " <<CylinderVolume() << "\n" << endl;
 }