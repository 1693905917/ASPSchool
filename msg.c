#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <sys/msg.h>
#include <errno.h>

#define MAX_TEXT 512


struct msg_st
{
 long int msg_type;
 char text[BUFSIZ];
};


int main(void)
{
  int msgid = -1;
  struct msg_st data;
  char buffer[BUFSIZ];
  long int msgtype = 2;
  int pid;
  while((pid = fork()) < 0);
  if(pid == 0)
    { 
      msgid = msgget((key_t)1234, 0666|IPC_CREAT);
      if(msgid == -1)
        {
          fprintf(stderr, "msgget failed error: %d\n", errno);
          exit(EXIT_FAILURE);
        }
      while(1)
           {
             printf("Enter some text:\n");
             fgets(buffer, BUFSIZ, stdin);
             data.msg_type = 2;
             strcpy(data.text, buffer);
   
             if(msgsnd(msgid, (void *)&data, MAX_TEXT, 0) == -1)
                {
                  fprintf(stderr, "msgsnd failed error: %d\n", errno);
                  exit(EXIT_FAILURE);   
                }
            }
  
     }
  else
     {
      //wait(0);
      msgid = msgget((key_t)1234, 0666|IPC_CREAT);
      if(msgid == -1)
        {
          fprintf(stderr, "msgget failed with error %d\n", errno);
          exit(EXIT_FAILURE);
         }
    
      while(1)
         {
           if(msgrcv(msgid, (void*)&data, BUFSIZ, msgtype, 0) == -1)
           fprintf(stderr, "msgrcv failed with erro: %d\n", errno);
           printf("you wrote: %s\n", data.text);
          }  

       }
  }


