#include <iostream>
#include <string>

using namespace std;

class Person
{
    private:
        // properties
        int age;

    public:
        // constructor
        Person(int age)
        {
            // check if valid age
            if (age >= 0)
            {
                this->age = age;
            }
            else
            {
                cout << "Age is not valid, setting age to 0." << endl;
                this->age = 0;
            }
        }

        void yearPasses()
        {
            // increment age
            age++;
        }

        string amIOld()
        {
            // return age statement
            if (age < 13)
                return "You are young.";
            if (age < 18)
                return "You are a teenager.";

            return "You are old.";
        }
};

int main()
{
    // read total input numbers
    string s;
    getline(cin, s);
    int times = stoi(s);

    // loop number of times
    for (int i = 0; i < times; i++)
    {
        // read age of person
        getline(cin, s);

        // instantiate a person
        Person p(stoi(s));

        // print age statement
        cout << p.amIOld() << endl;

        // increment person age
        for (int j = 0; j < 3; j++)
            p.yearPasses();

        // print age statement
        cout << p.amIOld() << endl;
    }
    return 0;
}
