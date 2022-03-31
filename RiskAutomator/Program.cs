Random rnd = new Random();

void FindWinner(int attTroops, int defTroops)
{
    int[] AttackerRolls = new int[] { 0, 0, 0 };
    int[] DefenderRolls = new int[] { 0, 0 };

    int AttDice1 = 0;
    int AttDice2 = 0;
    int AttDice3 = 0;

    int DefDice1 = 0;
    int DefDice2 = 0;



    while (defTroops > 0 && attTroops > 1)
        if (attTroops == 2)
        {
            switch (defTroops)
            {
                //1 attacking dice, 1 defending dice
                case 1:

                    //Dice rolls
                    AttDice1 = rnd.Next(1, 7);

                    DefDice1 = rnd.Next(1, 7);


                    Console.WriteLine("\nAttackers: Dice 1 -> " + AttDice1);
                    Console.WriteLine("Defenders: Dice 1 -> " + DefDice1);


                    if (DefDice1 >= AttDice1)
                    {
                        attTroops--;
                        Console.WriteLine("Attackers lose 1 troop");
                        Console.WriteLine("Attackers: " + attTroops + ", Defenders: " + defTroops);
                    }
                    else
                    {
                        defTroops--;
                        Console.WriteLine("Defenders lose 1 troop");
                        Console.WriteLine("Attackers: " + attTroops + ", Defenders: " + defTroops);
                    }
                    break;
                //1 attacking dice, 2 defending dice
                default:

                    //Dice rolls
                    AttDice1 = rnd.Next(1, 7);

                    DefenderRolls[0] = rnd.Next(1, 7);
                    DefenderRolls[1] = rnd.Next(1, 7);
                    Array.Sort(DefenderRolls);
                    Array.Reverse(DefenderRolls);
                    DefDice1 = DefenderRolls[0];
                    DefDice2 = DefenderRolls[1];


                    Console.WriteLine("\nAttackers: Dice 1 -> " + AttDice1);
                    Console.WriteLine("Defenders: Dice 1 -> " + DefDice1 + ", Dice 2 -> " + DefDice2);


                    if (DefDice1 >= AttDice1 || DefDice2 >= AttDice1)
                    {
                        attTroops--;
                        Console.WriteLine("Attackers lose 1 troop");
                        Console.WriteLine("Attackers: " + attTroops + ", Defenders: " + defTroops);
                    }
                    else
                    {
                        defTroops--;
                        Console.WriteLine("Defenders lose 1 troop");
                        Console.WriteLine("Attackers: " + attTroops + ", Defenders: " + defTroops);
                    }
                    break;
            }
        }
        else if (attTroops == 3)
        {
            switch (defTroops)
            {
                //2 attacking dice, 1 defending dice
                case 1:

                    //Dice rolls
                    AttackerRolls[0] = rnd.Next(1, 7);
                    AttackerRolls[1] = rnd.Next(1, 7);
                    Array.Sort(AttackerRolls);
                    Array.Reverse(AttackerRolls);
                    AttDice1 = AttackerRolls[0];
                    AttDice2 = AttackerRolls[1];

                    DefDice1 = rnd.Next(1, 7);


                    Console.WriteLine("\nAttackers: Dice 1 -> " + AttDice1 + ", Dice 2 -> " + AttDice2);
                    Console.WriteLine("Defenders: Dice 1 -> " + DefDice1);


                    if (DefDice1 >= AttDice1)
                    {
                        attTroops--;
                        Console.WriteLine("Attackers lose 1 troop");
                        Console.WriteLine("Attackers: " + attTroops + ", Defenders: " + defTroops);
                    }
                    else if (DefDice1 < AttDice1)
                    {
                        defTroops--;
                        Console.WriteLine("Defenders lose 1 troop");
                        Console.WriteLine("Attackers: " + attTroops + ", Defenders: " + defTroops);
                    }
                    break;
                //2 attacking dice, 2 defending dice
                default:

                    //Dice rolls
                    AttackerRolls[0] = rnd.Next(1, 7);
                    AttackerRolls[1] = rnd.Next(1, 7);
                    Array.Sort(AttackerRolls);
                    Array.Reverse(AttackerRolls);
                    AttDice1 = AttackerRolls[0];
                    AttDice2 = AttackerRolls[1];

                    DefenderRolls[0] = rnd.Next(1, 7);
                    DefenderRolls[1] = rnd.Next(1, 7);
                    Array.Sort(DefenderRolls);
                    Array.Reverse(DefenderRolls);
                    DefDice1 = DefenderRolls[0];
                    DefDice2 = DefenderRolls[1];


                    Console.WriteLine("\nAttackers: Dice 1 -> " + AttDice1 + ", Dice 2 -> " + AttDice2);
                    Console.WriteLine("Defenders: Dice 1 -> " + DefDice1 + ", Dice 2 -> " + DefDice2);


                    if (DefDice1 >= AttDice1 && DefDice2 >= AttDice2)
                    {
                        attTroops -= 2;
                        Console.WriteLine("Attackers lose 2 troops");
                        Console.WriteLine("Attackers: " + attTroops + ", Defenders: " + defTroops);
                    }
                    else if (AttDice1 > DefDice1 && AttDice2 > DefDice2)
                    {
                        defTroops -= 2;
                        Console.WriteLine("Defenders lose 2 troops");
                        Console.WriteLine("Attackers: " + attTroops + ", Defenders: " + defTroops);
                    }
                    else if ((DefDice1 >= AttDice1 && AttDice2 > DefDice2) || (DefDice1 < AttDice1 && DefDice2 >= AttDice2))
                    {
                        attTroops--;
                        Console.WriteLine("Attackers lose 1 troop. ");
                        defTroops--;
                        Console.WriteLine("Defenders lose 1 troop");
                        Console.WriteLine("Attackers: " + attTroops + ", Defenders: " + defTroops);
                    }
                    break;
            }
        }
        else
        {
            switch (defTroops)
            {
                //3 attacking dice, 1 defending dice
                case 1:

                    //Dice rolls
                    AttackerRolls[0] = rnd.Next(1, 7);
                    AttackerRolls[1] = rnd.Next(1, 7);
                    AttackerRolls[2] = rnd.Next(1, 7);
                    Array.Sort(AttackerRolls);
                    Array.Reverse(AttackerRolls);
                    AttDice1 = AttackerRolls[0];
                    AttDice2 = AttackerRolls[1];
                    AttDice3 = AttackerRolls[2];

                    DefDice1 = rnd.Next(1, 7);


                    Console.WriteLine("\nAttackers: Dice 1 -> " + AttDice1 + ", Dice 2 -> " + AttDice2 + ", Dice 3 -> " + AttDice3);
                    Console.WriteLine("Defenders: Dice 1 -> " + DefDice1);


                    if (DefDice1 >= AttDice1)
                    {
                        attTroops--;
                        Console.WriteLine("Attackers lose 1 troop");
                        Console.WriteLine("Attackers: " + attTroops + ", Defenders: " + defTroops);
                    }
                    else if (DefDice1 < AttDice1)
                    {
                        defTroops--;
                        Console.WriteLine("Defenders lose 1 troop");
                        Console.WriteLine("Attackers: " + attTroops + ", Defenders: " + defTroops);
                    }
                    break;
                //3 attacking dice, 2 defending dice
                default:

                    //Dice rolls
                    AttackerRolls[0] = rnd.Next(1, 7);
                    AttackerRolls[1] = rnd.Next(1, 7);
                    AttackerRolls[2] = rnd.Next(1, 7);
                    Array.Sort(AttackerRolls);
                    Array.Reverse(AttackerRolls);
                    AttDice1 = AttackerRolls[0];
                    AttDice2 = AttackerRolls[1];
                    AttDice3 = AttackerRolls[2];

                    DefenderRolls[0] = rnd.Next(1, 7);
                    DefenderRolls[1] = rnd.Next(1, 7);
                    Array.Sort(DefenderRolls);
                    Array.Reverse(DefenderRolls);
                    DefDice1 = DefenderRolls[0];
                    DefDice2 = DefenderRolls[1];


                    Console.WriteLine("\nAttackers: Dice 1 -> " + AttDice1 + ", Dice 2 -> " + AttDice2 + ", Dice 3 -> " + AttDice3);
                    Console.WriteLine("Defenders: Dice 1 -> " + DefDice1 + ", Dice 2 -> " + DefDice2);


                    if (DefDice1 >= AttDice1 && DefDice2 >= AttDice2)
                    {
                        attTroops -= 2;
                        Console.WriteLine("Attackers lose 2 troops");
                        Console.WriteLine("Attackers: " + attTroops + ", Defenders: " + defTroops);
                    }
                    else if (AttDice1 > DefDice1 && AttDice2 > DefDice2)
                    {
                        defTroops -= 2;
                        Console.WriteLine("Defenders lose 2 troops");
                        Console.WriteLine("Attackers: " + attTroops + ", Defenders: " + defTroops);
                    }
                    else if ((DefDice1 >= AttDice1 && AttDice2 > DefDice2) || (DefDice1 < AttDice1 && DefDice2 >= AttDice2))
                    {
                        attTroops--;
                        Console.WriteLine("Attackers lose 1 troop. ");
                        defTroops--;
                        Console.WriteLine("Defenders lose 1 troop");
                        Console.WriteLine("Attackers: " + attTroops + ", Defenders: " + defTroops);
                    }
                    break;
            }
        }


    if (defTroops == 0)
    {
        Console.WriteLine("\nAttackers won with " + attTroops + " troops remaining");
    }
    else if (attTroops == 1 && defTroops > 0)
    {
        Console.WriteLine("\nDefenders won with " + defTroops + " troops remaining. Attackers have 1 left.");
    }

}

// IO
Console.WriteLine("Enter amount of ATTACKING units");
string AttackerUnits = Console.ReadLine();

Console.WriteLine("Enter Amount of DEFENDING units");
string DefenderUnits = Console.ReadLine();

FindWinner(Int32.Parse(AttackerUnits), Int32.Parse(DefenderUnits));
