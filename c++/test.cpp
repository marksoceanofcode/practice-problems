#include <iostream>
#include <string>
using namespace std;

int main(){
    string fullName = "";

    cout << "Initializing..." << std::endl;
    cout << "Initializing..." << std::endl;
    cout << "Initializing...\n\n";
    cout << "Enter your name: ";
    getline(cin, fullName);

    cout << "Hello " + fullName + "!\n";
    return 0;
}