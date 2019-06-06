#include <algorithm>
using namespace std;
// you can write to stdout for debugging purposes, e.g.
// cout << "this is a debug message" << endl;

int solution(vector<int> &A) {
    if(A.size() < 3)
        return 0;
    
    sort(A.begin(), A.end());

    for(int i = A.size()-1; i >= 2; i--){
        if((A[i]+A[i-1] > A[i-2]) && (A[i]+A[i-2] > A[i-1]) && (A[i-2]+A[i-1] > A[i]))
            return 1;
    }
    
    return 0;
