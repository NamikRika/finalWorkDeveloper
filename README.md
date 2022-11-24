# Итоговый тест "Выбор специализации. IT-специалист" была поставлена задача.

>Задача: 
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## Решение: 
### (алгоритм действия)

1. Запрашиваем у пользователя размер массива
2. Передаём размер массива в функцию  ***[заполнения массива строк]***
3. Функция  ***[заполнения массива строк]*** возвращает пользователю запрос на ввод слов. Запрос выводиться через цикл, то количество раз, которому равен размер массива заданный пользователем.
4. По мере того как пользователь вводит слова, заполняется строковый массив.
5. После того как цикл "запроса ввода слов" от пользователя будет завершён, начинает работу функция ***[Вывода массива строк]***. В этой функции срабатывает условие, при котором, циклом перебираются все значения массива и в случае если какое-либо значение будет удовлетворять условию ***"<= 3 символам"*** то эти значения будут выведены на экран. После окончания цикла программа будет завершена.

6. В случае если ни одно значение не будет соответствовать заданному условию, программа выведет на экран сообщение о том, что по заданному критерию данных нет.



