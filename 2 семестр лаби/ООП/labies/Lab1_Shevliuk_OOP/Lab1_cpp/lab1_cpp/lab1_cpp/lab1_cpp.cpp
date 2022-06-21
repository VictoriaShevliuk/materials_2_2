#include <iostream>
#include <string>
#include "TCircle.h"
#include "TCylinder.h"

using namespace std;

double InputHeight()
{
    double inputheight;
    cout << "Введiть висоту для вашого цилiдра: " << endl;
    cin >> inputheight;
    return inputheight;
}

double InputRadius()
{
    double inputradius;
    cout << "Введiть радiус вашого кола: " << endl;
    cin >> inputradius;
    return inputradius;
}

int main()
{
    setlocale(LC_ALL, "Rus");
    TCircle cir0 =  InputRadius();
    cir0.CircleInfo();
    cout<<"Створюю ще одне коло... Збiльшую його радiус!"<<endl;
    TCircle cir1 = cir0 + TCircle(5);
    cir1.CircleInfo();
    cout << "Порiвняємо Ваше коло з тим, що я зробив  ;)"<<endl;
    cir0.CircleCompare(cir1);
    cout << "\n\nТепер на основi цих кiл створимо цилiндри! \n\n " << endl;
    double height = InputHeight();
    TCylinder cyl1 =  TCylinder(cir0.GetRadius(), height);
    cout<<"Перший цилiндр: \n"<<endl;
    cyl1.CylinderInfo();
    TCylinder cyl2 =  TCylinder(cir1.GetRadius(), height);
    cout<<"Другий цилiндр: \n"<<endl;
    cyl2.CylinderInfo();
    cout<<"Порiвняємо цi два цилiндри! \n"<<endl;
    cyl1.CylinderCompare(cyl2);

}


