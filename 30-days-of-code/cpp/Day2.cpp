#include <iostream>
#include <string>

using namespace std;

int totalCost(double meal_cost, int tip_percent, int tax_percent)
{
    // return total cost
    return round(meal_cost + (meal_cost * tip_percent / 100) + (meal_cost * tax_percent / 100));
}

int main()
{
    // read input
    string s;
    getline(cin, s);
    double meal_cost = stod(s);
    getline(cin, s);
    int tip_percent = stoi(s);
    getline(cin, s);
    int tax_percent = stoi(s);

    // print total cost statement
    cout << totalCost(meal_cost, tip_percent, tax_percent);

    return 0;
}
