int ShowNums(int firstusernum, int finishusernum)
{
     if (firstusernum == 0) return (finishusernum * (finishusernum + 1)) / 2;           
    else if (finishusernum == 0) return (firstusernum * (firstusernum + 1)) / 2;       
    else if (firstusernum == finishusernum) return firstusernum;                      
    else if (firstusernum < finishusernum) return finishusernum + ShowNums(firstusernum, finishusernum - 1); 
    else return firstusernum + ShowNums(firstusernum, finishusernum + 1);
}

Console.Write("Enter your first number: ");
int usernumber1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter your second(finish) number: ");
int usernumber2 = Convert.ToInt32(Console.ReadLine());
Console.Write(ShowNums(usernumber1, usernumber2));