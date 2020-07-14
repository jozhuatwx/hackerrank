#include <iostream>
#include <string>

using namespace std;

int main()
{
    // read input
    string s;
    getline(cin, s);
    int input = stoi(s);

    // print multiplication table
    for (int i = 1; i < 11; i++)
        cout << input << " x " << i << " = " << input * i << endl;
    return 0;
}
