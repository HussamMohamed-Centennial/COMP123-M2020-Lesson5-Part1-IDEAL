using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_M2020_Lesson5_Part1_IDEAL
{
    class Program
    {
        static void Main(string[] args)
        {
            //GameObject player=new GameObject("Player");
            Player player=new Player();
            float playerSpeed = 20.0f; //20 units
            Enemy greenEnemy = new Enemy("GreenEnemy");
            Enemy redEnemy = new Enemy("RedEnemy");
            BossEnemy bossEnemy = new BossEnemy();

             //player.Transform.postion = new Vector2D();

             player.RaiseSheild();
             player.Transform.postion = new Vector2D(100.0f , 100.0f);
             Console.WriteLine(player.ToString());


             player.Transform.postion += Vector2D.Up() * playerSpeed;
             Console.WriteLine(player.ToString());
             
             Vector2D vectorOne = new Vector2D(0.0f ,3.0f);
             Vector2D vectorTwo = new Vector2D(4.0f ,10.0f);
             Console.WriteLine("Value of vector one is: " + vectorOne.ToString());
             Console.WriteLine("Value of vector two is: " + vectorTwo.ToString());

            float dot = Vector2D.Dot(vectorOne, vectorTwo);
             Console.WriteLine($"The dot Product is: {dot}");

             float distance = Vector2D.Distance(vectorOne, vectorTwo);
             Console.WriteLine($"The distance between vectorOne and vectorTwo is:  {distance}");



            // greenEnemy.FireBullet();
            // greenEnemy.Transform.postion=new Vector2D(60.0f,80.0f);
            // Console.WriteLine(greenEnemy.ToString());

            // redEnemy.FireBullet();
            // redEnemy.Transform.postion=new Vector2D();
            // Console.WriteLine(redEnemy.ToString());

            //bossEnemy.FireBullet();
            //bossEnemy.Transform.postion = new Vector2D(200.0f ,200.0f);
            //Console.WriteLine(bossEnemy.ToString());

            //listen for any key
            Console.ReadLine();

        }
    }
}
