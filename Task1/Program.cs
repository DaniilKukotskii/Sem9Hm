int ShowNums(int usernum, int finishnum)
{
    if (usernum < 1) 
    {
        return finishnum;
    }
    Console.Write(usernum + " ");
    usernum--;
    return ShowNums(usernum, finishnum);
}

Console.Write("How many numbers to print: ");
int usernumber = Convert.ToInt32(Console.ReadLine());
ShowNums(usernumber, 1);