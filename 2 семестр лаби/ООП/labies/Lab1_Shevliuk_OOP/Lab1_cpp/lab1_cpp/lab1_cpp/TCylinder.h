#pragma once
#include <string>
#include <cmath>
#include "TCircle.h"

using namespace std;

class TCylinder : public TCircle {
private: double height;
public:

	TCylinder();
	TCylinder(double radius, double height);
	TCylinder( const TCylinder& cylinder);
	double GetHeight() const;
	double SetHeight(int radius);
	double CylinderVolume();
	void CylinderCompare(TCylinder cylinder);
	void CylinderInfo();
};


