#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

// num_list_len은 배열 num_list의 길이입니다.
int solution(int num_list[], size_t num_list_len) {
    int mul = 1;
    int add = 0;
    for(int i=0; i<num_list_len; i++){
        mul *= num_list[i];
        add += num_list[i];
    }
    
    if (mul < add * add){
        return 1;
    }
    if (mul > add * add){
        return 0;
    }

}