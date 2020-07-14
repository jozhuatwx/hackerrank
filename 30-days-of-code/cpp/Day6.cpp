#include <iostream>
#include <string>

using namespace std;

int main()
{
    // read total input strings
    string s;
    getline(cin, s);
    int times = stoi(s);

    // loop number of times
    for (int i = 0; i < times; i++)
    {
        // read input
        string input;
        getline(cin, input);
        
        // print even characters
        for (int j = 0; j < input.length(); j = j + 2)
            cout << input[j];
        
        // print spacing
        cout << " ";

        // print odd characters
        for (int j = 1; j < input.length(); j = j + 2)
            cout << input[j];
        
        // print new line
        cout << endl;
    }

    return 0;
}
