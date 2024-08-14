#include<stdlib.h>
#include<stdio.h>

int main(int argc, char *argv[])
{
 if(argc < 3)
   {
     printf("input error!\n");
     exit(0);
   }
 int p1 = (atoi)argv[1];
 int p2 = (atoi)argv[2];
 printf("p1=%d\n", p1);
 printf("p2=%d\n", p2);
 printf("The sum is : %d\n", p1+p2);
 return 0;

}