using System.Collections.Generic;
namespace Sieve
{
  public class Filter
  {
    public static List<int> primes(int limit){
      int n = limit;
      List<int> list = new List<int>{2};
      for(int i = 2; i<=n; i++){
        bool prime = false;
        for(int j = 2; j<i; j++){
          if(i%j != 0){
            prime = true;
          }else{
            prime = false;
            break;
          }
        }
        if(prime){
          list.Add(i);
        }
      }
      return list;
    }
  }

}
