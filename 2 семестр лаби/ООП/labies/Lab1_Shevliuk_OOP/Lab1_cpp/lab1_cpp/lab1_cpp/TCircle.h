#pragma once
#include <string>
#include <cmath>

using namespace std;

class TCircle
{
private:  double radius;
public: 



	TCircle();
	TCircle(double radius);
	TCircle(const TCircle& circle);
	double GetRadius() const;
	double SetRadius(int radius);
	double CircleSquare();
	double CircleLength();
	void CircleCompare(TCircle circle);
	void CircleInfo();
	friend TCircle operator +(TCircle cir1, TCircle cir2);
	friend TCircle operator -(TCircle cir1, TCircle cir2);
	friend TCircle operator *(TCircle cir, double num);
};

