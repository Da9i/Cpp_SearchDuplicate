#include<iostream>
using namespace std;
int searchDuplicate(int arr[],int size,int num)
{
	if (size == 0)
		return 0;
	for (int i = 0; i < size; i++)
	{
		for (int j = 0; j < size; j++)
		{
			if (num == arr[j])
				return -1;
		}
	}
	return 0;
}
int main()
{
	int arr[10], num, check = 0 , i = 0;
	while (i < 10)
	{
		num = rand() % 100;
		if (num >= 10 && num <= 100)
		{
			check = searchDuplicate(arr, i, num);
			if (check == 0)
			{
				arr[i] = num;
				i++;
			}
		}
	}
	cout << "NON DUPLICATED ELEMENTS: ";
	for (int i = 0; i < 10; i++)
		cout << arr[i] << " ";
	system("pause>0");
}
