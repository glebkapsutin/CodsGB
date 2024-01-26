//1

// void IntervalOFnumbers(int M, int N)
// {
//  if (M-1==N)
//  {
//   return;
//  }
 
//  Console.WriteLine(M);
//  ++M;
//  IntervalOFnumbers(M,N);
  
// }
// IntervalOFnumbers(1, 7);


//2

// int AkkermanFoo(int m,int n)
// {
//  if (m==0)
//  {
//     return n+1;
//  }
//  if (m>0 && n==0)
//  {
//     return AkkermanFoo(m-1,n);
//  }
//  if (m>0 && n>0)
//  {
//     return AkkermanFoo(m-1,AkkermanFoo(m,n-1));
//  }
//  return 0;
// }
// Console.WriteLine(AkkermanFoo(1,2));


//3


// int[] array={1,2,3,4,5,6,7,8};

// int NumberOFarr=0;
// ReverseARR(array,0);
// foreach (var item in array)
// {
//     Console.Write(item+" ");
// }
// void ReverseARR(int[] arr,int min)
// {   
//    int size1=arr.Length-1-min;
   
//    if (NumberOFarr>=size1)
//    {
//     return;
//    }
//    int temp= arr[NumberOFarr];
//    arr[NumberOFarr]=arr[size1];
//    arr[size1] = temp;
//    NumberOFarr+=1;
//    ReverseARR(arr,min+1);
   

    
// }



