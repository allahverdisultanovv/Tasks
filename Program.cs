#region TaskConditions
//1.Verilmish arrayda murekkeb ededleri ekrana çıxaran algorithm misal:input {5,9,12,11} output 9, 12

//2.Ədədlərdən ibarət İki array verilib. Hər iki arrayda mövcud olan elementleri ekrana çıxaran  algorithm
//(Məsələn {4,5,9,11,15} ve {1,5,13,15}   hər ikisində 5 və 15 var bunlar ekrana cixmalidir)

//3.Verilmish arrayin en boyuk ve en kicik elementlerinin indexlerini ekrana çıxaran  algorithm 
//misal: input {2, 5, 1, 8, 10} output en kicik deyerin indexi 2, en boyuk deyerin indexi 4

//4. Verilmish ededin mertebelerinin cemini tapan  algorithm .

//5.(optional) 1-den 10 qeder olan arrayda bir reqem eskikdir. Eskik olan reqemi tapan algorithm 
//  yazin ve nezere alin ki verilen arrayda reqemler siralanmadan duzulub misal: input {4, 1, 9, 6, 10, 2, 5, 8, 3} output 7

#endregion


//Task 1
#region CompoundNumber
//int[] nums = { 0, 12, 23, 51, 4, 3, 5, 7 };
//for (int i = 0; i < nums.Length; i++)
//{
//    int a = 2;
//    while (a <= nums[i] / 2)
//    {
//        if (nums[i] % a == 0)
//        {
//            Console.WriteLine(nums[i]);
//            break;
//        }
//        a++;

//    }
//} 
#endregion


//Task2
#region SameNumbers
//int[] nums = { 1, 5, 3, 56, 8, 7, 5, 6, 2, 1 };
//int[] nums2 = { 7, 56, 2, 88, 5, 12, 34, 52, 6, 5, 74, 22 };
//for (int i = 0; i < nums.Length; i++)
//{
//    for (int j = 0; j < nums2.Length; j++)
//    {
//        if (nums[i] == nums2[j])
//        {
//            Console.WriteLine(nums[i]);
//            break;

//        }
//    }
//} 
#endregion


//Task3
#region min/maxIndex
//int[] nums = { 15, 51, 21, 42, 4, 32, 41 };
//int max = nums[0];
//int min = nums[0];
//int maxIndex = 0;
//int minIndex = 0;
//for (int i = 0; i < nums.Length; i++)
//{
//    if (max < nums[i])
//    {
//        maxIndex = i;
//        max = nums[i];
//    }
//    else if (min > nums[i])
//    {
//        min = nums[i];
//        minIndex = i;
//    }

//}
//Console.WriteLine(minIndex);
//Console.WriteLine(maxIndex); 
#endregion


//Task4
#region NumsSum
//int num = 15345122;
//int sum = 0;
//while (num > 0)
//{
//    sum += num % 10;
//    num /= 10;
//}
//Console.WriteLine(sum); 
#endregion


//Task5(optional)
#region ForgottenNumber
//int[] nums = { 1, 9, 10, 3, 8, 7, 4, 5, 6 };
//for (int i = 1; i <= 10; i++)
//{
//    bool result = false;
//    for (int j = 0; j < nums.Length; j++)
//    {
//        if (nums[j] == i) { result = true; break; }
//    }
//    if (!result)
//    {
//        Console.WriteLine(i);
//    }
//} 

#endregion
