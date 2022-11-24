# Итоговый тест "Выбор специализации. IT-специалист" была поставлена задача.

>Задача: 
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## Решение: 
### (алгоритм действий)

1. Запрашиваем у пользователя размер массива
2. Передаём размер массива в функцию  ***[заполнения массива строк]***
3. Функция  ***[заполнения массива строк]*** возвращает пользователю запрос на ввод слов. Запрос выводиться через цикл, то количество раз, которому равен размер массива заданный пользователем.
4. По мере того как пользователь вводит слова, заполняется строковый массив.
5. После того как цикл "запроса ввода слов" от пользователя будет завершён, начинает работу функция ***[Вывода массива строк]***. В этой функции созадётся новый массив, который заполняется на основе первого массива по условию ***"<= 3 символам"***.
6. Как только массив по условию будет сформирован, циклом значения будут выведены на экран.

7. В случае если ни одно значение не будет соответствовать заданному условию, программа выведет на экран сообщение о том, что по заданному критерию данных нет.



