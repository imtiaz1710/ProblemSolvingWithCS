// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
anagram();

void anagram()
{
    var str1 = Console.ReadLine();
    var str2 = Console.ReadLine();

    if(str1?.Length != str2?.Length){
        Console.WriteLine("Not Anagram!");
        return;
    }
 
    var dict1 = new Dictionary<char, int>();
    var dict2 = new Dictionary<char, int>();

    for(int i = 0; i < str1?.Length;  i++) {
        dict1[str1[i]] = dict1.ContainsKey(str1[i]) ? dict1[str1[i]] + 1 : 0;
    }

    for(int i = 0; i < str2?.Length;  i++) {
        dict2[str2[i]] = dict2.ContainsKey(str2[i]) ? dict2[str2[i]] + 1 : 0;
    }

    foreach(var key in dict1.Keys) {
        if(!dict2.ContainsKey(key) || dict1[key] != dict2[key]) {
            Console.WriteLine("Not Anagram!");
            return;
        }
    }

    Console.WriteLine("Anagram!");
}
