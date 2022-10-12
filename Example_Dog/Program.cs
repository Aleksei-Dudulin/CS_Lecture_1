// direction of dog`s movement = Dir, distance = D, first friend speed = Vf1, second friend speed = Vf2, dog speed = Vd, time = T
int Dir = 2, D = 1000, Vf1 = 1, Vf2 = 2, Vd = 6, count = 0;

while (D > 2)
{
    if (Dir == 1)
    {
        int T = D / (Vf1 + Vd);
        Dir = 2;
        D = D - (Vf1 + Vf2) * T;
    }
    else
    {
        int T = D / (Vf2 + Vd);
        Dir = 1;
        D = D - (Vf1 + Vf2) * T;
    }
    count++;
}

Console.WriteLine("Собака пробежала между друдьями ");
Console.Write(count);
Console.Write(" раз.");