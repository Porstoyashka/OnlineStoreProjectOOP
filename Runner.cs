﻿using Newtonsoft.Json;

namespace OnlineStoreProjectOOP;

public class Runner
{
    public static readonly DataBaseWork dataBase = new DataBaseWork();
    public static User User;

    public static Task Main()
    {
        string file =
            File.ReadAllText(
                @"C:\Users\OnePlus\Projects\OnlineStoreProjectOOP\OnlineStoreProjectOOP\DataBase.json");
        dataBase.ProductsList = JsonConvert.DeserializeObject<List<Product>>(file);
        int idForProduct = dataBase.ProductsList![dataBase.ProductsList.Count - 1].ID;
        bool isReg = false;
        while (!isReg)
        {
            while (!isReg)
            {
                if (User.Reg() == false) Console.WriteLine("Incorrect login or password");
                else isReg = true;
            }
        }

        int i = 0;
        while (i != 6)
        {
            try
            {
                if (i == 0)
                {
                    Console.WriteLine("\t Menu");
                    Console.WriteLine("(1)->See the list of products");
                    Console.WriteLine("(2)->Top up the balance");
                    Console.WriteLine("(3)->Buy things");
                    Console.WriteLine("(4)->Personal data");
                    Console.WriteLine("(5)->Add product");
                    Console.WriteLine("(6)->Sign out of the account");
                    Console.Write("Enter number: ");
                    i = Convert.ToInt32(Console.ReadLine());
                    continue;
                }

                if (i == 1)
                {
                    Console.WriteLine("(1)->Clothing list");
                    Console.WriteLine("(2)->List of gadgets");
                    Console.WriteLine("(3)->Food list");
                    Console.WriteLine("(4)->List of sporting things");
                    Console.WriteLine("(5)->Another");
                    Console.WriteLine("(0)->Menu");
                    i = Convert.ToInt32(Console.ReadLine());
                    if (i == 1)
                    {
                        dataBase.Show(Category.Clothes);
                        Console.WriteLine("(0)->Menu");
                        Console.WriteLine("(1)->Add to cart");
                        Console.WriteLine("(2)->See the list of products");
                        i = Convert.ToInt32(Console.ReadLine());
                        if (i == 1)
                        {
                            Console.Write("Id: ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            try
                            {
                                if (dataBase.SetProduct(id).Type != Category.Clothes)
                                    Console.WriteLine("The product with this ID isn't in this category");
                                else User.AddBasket(id);
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("A product with this ID doesn't exist");
                            }

                            i = 0;
                        }
                        else if (i == 2)
                        {
                            i = 1;
                            continue;
                        }
                    }

                    if (i == 2)
                    {
                        dataBase.Show(Category.Gadget);
                        Console.WriteLine("(0)->Menu");
                        Console.WriteLine("(1)->Add to cart");
                        Console.WriteLine("(2)->See the list of products");
                        i = Convert.ToInt32(Console.ReadLine());
                        if (i == 1)
                        {
                            Console.Write("Id: ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            try
                            {
                                if (dataBase.SetProduct(id).Type != Category.Gadget)
                                    Console.WriteLine("The product with this ID isn't in this category");
                                else User.AddBasket(id);
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("A product with this ID doesn't exist");
                            }

                            i = 0;
                        }
                        else if (i == 2)
                        {
                            i = 1;
                            continue;
                        }
                    }

                    if (i == 3)
                    {
                        dataBase.Show(Category.Food);
                        Console.WriteLine("(0)->Menu");
                        Console.WriteLine("(1)->Add to cart");
                        Console.WriteLine("(2)->See the list of products");
                        i = Convert.ToInt32(Console.ReadLine());
                        if (i == 1)
                        {
                            Console.Write("Id: ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            try
                            {
                                if (dataBase.SetProduct(id).Type != Category.Food)
                                    Console.WriteLine("The product with this ID isn't in this category");
                                else User.AddBasket(id);
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("A product with this ID doesn't exist");
                            }

                            i = 0;
                        }
                        else if (i == 2)
                        {
                            i = 1;
                            continue;
                        }
                    }

                    if (i == 4)
                    {
                        dataBase.Show(Category.Sport);
                        Console.WriteLine("(0)->Menu");
                        Console.WriteLine("(1)->Add to cart");
                        Console.WriteLine("(2)->See the list of products");
                        i = Convert.ToInt32(Console.ReadLine());
                        if (i == 1)
                        {
                            Console.Write("Id: ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            try
                            {
                                if (dataBase.SetProduct(id).Type != Category.Sport)
                                    Console.WriteLine("The product with this ID isn't in this category");
                                else User.AddBasket(id);
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("A product with this ID doesn't exist");
                            }

                            i = 0;
                        }
                        else if (i == 2)
                        {
                            i = 1;
                            continue;
                        }
                    }

                    if (i == 5)
                    {
                        dataBase.Show(Category.Another);
                        Console.WriteLine("(0)->Menu");
                        Console.WriteLine("(1)->Add to cart");
                        Console.WriteLine("(2)->See the list of products");
                        i = Convert.ToInt32(Console.ReadLine());
                        if (i == 1)
                        {
                            Console.Write("Id: ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            try
                            {
                                if (dataBase.SetProduct(id).Type != Category.Sport)
                                    Console.WriteLine("The product with this ID isn't in this category");
                                else User.AddBasket(id);
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("A product with this ID doesn't exist");
                            }

                            i = 0;
                        }
                        else if (i == 2)
                        {
                            i = 1;
                        }
                    }

                    continue;
                }

                if (i == 2)
                {
                    Console.Write("Enter the sum for which you want to top up the account:");
                    i = Convert.ToInt32(Console.ReadLine());
                    User.Card.SetSum(User.Card.GetSum() + i);
                    i = 0;
                    continue;
                }

                if (i == 3)
                {
                    User.ShowBasket();
                    Console.WriteLine("(0)->Menu");
                    Console.WriteLine("(1)->Buy things");
                    i = Convert.ToInt32(Console.ReadLine());
                    if (i == 1)
                    {
                        User.Buy();
                        i = 0;
                    }

                    continue;
                }

                if (i == 4)
                {
                    User.DaniUser();
                    i = 0;
                }

                if (i == 5)
                {
                    Console.WriteLine("Enter the name of the product: ");
                    string? name = Convert.ToString(Console.ReadLine());
                    Console.WriteLine(
                        "Enter the Type of the product \n1-Sport \n2-Clothes \n3-Gadget \n4-Food \n5-Another");
                    int kategory = Convert.ToInt32(Console.ReadLine());
                    Category type;
                    if (kategory == 1) type = Category.Sport;
                    else if (kategory == 2) type = Category.Clothes;
                    else if (kategory == 3) type = Category.Gadget;
                    else if (kategory == 4) type = Category.Food;
                    else if (kategory == 5) type = Category.Another;
                    else
                    {
                        Console.WriteLine("Invalidd value entered");
                        i = 0;
                        continue;
                    }

                    Console.WriteLine("Enter price: ");
                    double price = Convert.ToDouble(Console.ReadLine());
                    dataBase.ProductsList.Add(new Product(++idForProduct, type, name, price));
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid value entered");
            }

            i = 0;
        }

        File.WriteAllText(@"C:\Users\OnePlus\Projects\OnlineStoreProjectOOP\OnlineStoreProjectOOP\DataBase.json",
            JsonConvert.SerializeObject(dataBase.ProductsList, Formatting.Indented));
        return Task.CompletedTask;
    }
}
