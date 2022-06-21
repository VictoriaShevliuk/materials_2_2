#include "TCircle.h"
#include <iostream>
using namespace std;
int mult_num = 3;

TCircle::TCircle() {
	 radius = 0;
}

TCircle::TCircle(double radius)
{
	this->radius = radius;
}

TCircle::TCircle(const TCircle& circle) {
	this->radius = circle.GetRadius();
}

double TCircle::GetRadius()const
{
	return radius;
}

double TCircle::SetRadius(int radius)
{
	return this->radius = radius;
}

double TCircle::CircleSquare()
{
	return 3.14 * (radius*radius);
}

double TCircle::CircleLength()
{
	return 3.14 * radius * 2;
}

void TCircle::CircleCompare(TCircle circle)
{
    if (circle.GetRadius() > radius)
    {
        cout << "Друге коло бiльше за перше!"<< endl;
    }
    else if (circle.GetRadius() == radius)
    {
       cout<<"Цi кола рiвнi!"<<endl;
    }
    else if (circle.GetRadius() < radius)
    {
        cout << "Перше коло бiльше за друге!" << endl;
    }
}


TCircle operator +( TCircle cir1, TCircle cir2)
{
    return TCircle(cir1.GetRadius() + cir2.GetRadius());
}

TCircle operator -(TCircle cir1, TCircle cir2)
{
    return (cir1.GetRadius() - cir2.GetRadius());
}

TCircle operator *(TCircle cir, double num)
{
    return (cir.GetRadius() * num);
}

void TCircle::CircleInfo()
{
    
   
    cout << std::string("Радiус кола: ") << GetRadius() << "\n" << "Довжина кола: " << CircleLength() <<
        "\n" << "Площа кола: " << CircleSquare() << "\n" << "Сума радiусiв двох однакових кiл: " <<
        GetRadius() + GetRadius() << "\n" << "Радiус кола, помножений на " << mult_num << ": "<< GetRadius() * mult_num<<
        "\n"<<"Рiзниця мiж Вашим та помноженим на число радіусами кіл: " << GetRadius() * mult_num - GetRadius() <<"\n" <<endl;
        
        
}