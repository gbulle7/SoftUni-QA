double changeUsd = double.Parse(Console.ReadLine());
int changeCents  = Convert.ToInt32(changeUsd * 100);
int coinsCount = 0;

coinsCount += changeCents / 200;
changeCents %= 200;
coinsCount += changeCents / 100;
changeCents %= 100;
coinsCount += changeCents / 50;
changeCents %= 50;
coinsCount += changeCents / 20;
changeCents %= 20;
coinsCount += changeCents / 10;
changeCents %= 10;
coinsCount += changeCents / 5;
changeCents %= 5;
coinsCount += changeCents / 2;
changeCents %= 2;
coinsCount += changeCents / 1;
Console.WriteLine(coinsCount);