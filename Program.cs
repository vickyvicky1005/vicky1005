// See https://aka.ms/new-console-template for more information
bool Start=true;  
bool Show=false;

string Name ="";
string Gender="";
string Birth="";
string StudentNum="";

string ChangeThis="";
string Correct="";

while(Start==true)
{
Console.WriteLine("請輸入姓名:");
Name = Console.ReadLine();

Console.WriteLine("請輸入性別:");
Gender = Console.ReadLine();

Console.WriteLine("請輸入出生年月日:");
Birth = Console.ReadLine();

Console.WriteLine("請輸入學號:");
StudentNum = Console.ReadLine();
Show=true;
  while(Show==true)
    { 
    Console.WriteLine("----------------------------------------------------------------------------------------------");
    Console.WriteLine("你的名字是:"+Name+"  你的性別是:"+Gender+"  你的出生日期是:"+Birth+"  你的學號是:"+StudentNum);
    Console.WriteLine("請問資料是否正確?1為正確 2為錯誤 其他則跳回");
    Correct = Console.ReadLine();
        if (Correct=="1")
        {
         Show=false;
         Start=false;
         Console.WriteLine("資料建構完成!");
        }
        else if (Correct=="2")
        {
            Console.WriteLine("請問要改哪筆資料?輸入:1名字 2性別 3生日 4學號 ");
            ChangeThis=Console.ReadLine();
            switch(ChangeThis)
            {
                case"1":
                Console.WriteLine("請輸入新的姓名:");
                Name = Console.ReadLine();
                Console.WriteLine("資料建構完成!");
                Show=false;
                ChangeThis="";
                break;

                case"2":
                Console.WriteLine("請輸入新的性別:");
                Gender = Console.ReadLine();
                Console.WriteLine("資料建構完成!");
                ChangeThis="";
                break;

                case"3":
                Console.WriteLine("請輸入新的生日:");
                Birth = Console.ReadLine();
                Console.WriteLine("資料建構完成!");
                ChangeThis="";
                break;

                case"4":
                Console.WriteLine("請輸入新的學號:");
                StudentNum = Console.ReadLine();
                Console.WriteLine("資料建構完成!");
                ChangeThis="";
                break;

                default:
                ChangeThis="";
                break;
                
            }
            
            
         }
    }

 }