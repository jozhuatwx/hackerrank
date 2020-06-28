#include <iostream>
#include <string>

using namespace std;

int main()
{
    // initialisation
    int i = 4;
    double d = 4.0;
    string s = "HackerRank ";

    // read input
    string s2;
    getline(cin, s2);
    int i2 = stoi(s2);
    getline(cin, s2);
    double d2 = stod(s2);
    getline(cin, s2);

    // print sum statement
    cout << i + i2 << endl;
    cout.precision(1);
    cout << fixed << d + d2 << endl;
    cout << s + s2 << endl;

    return 0;
}
