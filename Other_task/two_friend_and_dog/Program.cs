//Вычислить сколько раз собака пробежит от 1 друга ко второму, пока они двигаются на встречу к друг другу

Console.Clear();


int count = 0;
int distance = 10000;
int OneFriendSpeed = 1;
int TwoFriendSpeed = 2;
int dogSpeed = 5;
int friend = 2;
int time = 0;

while (distance < 10000)
{
    if (friend == 1)
    {
        time = distance / (OneFriendSpeed + dogSpeed);
        friend = 2;
        System.Console.WriteLine(time + "первый");
    }
    else
    {
        time = distance / (TwoFriendSpeed + dogSpeed);
        friend = 1;
    }
    distance = distance - (OneFriendSpeed + TwoFriendSpeed) * time;
    count++;
}



