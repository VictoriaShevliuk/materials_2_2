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
        cout << "����� ���� �i���� �� �����!"<< endl;
    }
    else if (circle.GetRadius() == radius)
    {
       cout<<"�i ���� �i��i!"<<endl;
    }
    else if (circle.GetRadius() < radius)
    {
        cout << "����� ���� �i���� �� �����!" << endl;
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
    
   
    cout << std::string("���i�� ����: ") << GetRadius() << "\n" << "������� ����: " << CircleLength() <<
        "\n" << "����� ����: " << CircleSquare() << "\n" << "���� ���i��i� ���� ��������� �i�: " <<
        GetRadius() + GetRadius() << "\n" << "���i�� ����, ���������� �� " << mult_num << ": "<< GetRadius() * mult_num<<
        "\n"<<"�i����� �i� ����� �� ���������� �� ����� �������� ��: " << GetRadius() * mult_num - GetRadius() <<"\n" <<endl;
        
        
}