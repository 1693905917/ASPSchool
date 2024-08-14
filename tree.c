#include <stdio.h>
main( )
{
int p1,p2,i;
while((p1=fork( ))== -1);          /*创建子进程p1*/
if (p1==0)  //A分支
  {
   while((p1=fork( ))== -1);
   if(p1 == 0)
     printf("C\n");
   else
   {
     while((p1=fork( ))== -1);
     if(p1 == 0)
       printf("D\n");
     else
       printf("A\n");
   }
  } 
else
 {
    while((p1=fork( ))== -1);          /*创建子进程p1*/
    if (p1==0)  //B分支
     {
      while((p1=fork( ))== -1);
      if(p1 == 0)
        printf("E\n");
      else
       {
        while((p1=fork( ))== -1);
        if(p1 == 0)
          printf("F\n");
        else
          printf("B\n");
       }
     }
   else
     printf("parent\n"); 

  }
}