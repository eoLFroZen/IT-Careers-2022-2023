using IntList = DynamicList.DynamicList<char>;

IntList dynamicList = new IntList();
dynamicList.Add('1');
dynamicList.Add('2');
dynamicList.Add('3');

Console.WriteLine(dynamicList[1]);

dynamicList.Remove('3');
dynamicList.Remove(0);

Console.WriteLine(dynamicList.Size);