#include <iostream>
#include <string>

using namespace std;

string conditionalStatement(int i)
{
    // return conditional statement
    if (i % 2 != 0)
        return "Weird";
    if (i > 20)
        return "Not Weird";
    if (i >= 6)
        return "Weird";

    return "Not Weird";
}

int main()
{
    // read input
    string s;
    getline(cin, s);
    int i = stoi(s);

    // print conditional statement
    cout << conditionalStatement(i);
    return 0;
}
