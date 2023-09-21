; Задание 3. Увеличения на 1 и записи в выходной порт 30h большего из чисел: в записанного
; во входном порту 20h и числом из порта 25h; при равенстве чисел записывать
; в выходной порт число 0FFh.

$ADR 0000h      ; Адрес начала программы

	; Инициализация ячеек памяти значениями из порта 20 и 25
	IN 20h		; Чтение данных из порта 20h в аккумулятор
	MOV B, A	; Передача содержимого аккумулятора в регистр B
	IN 25h		; Чтение данных из порта 25h в аккумулятор	
	MOV C, A	; Передача содержимого аккумулятора в регистр C
	SUB B;		; Вычитание содержимого регистра B из содержимого аккумулятора и сохранение итога в аккумуляторе
	JM ONE;		; Если результат меньше нуля, перейти к метке 'ONE'
	JZ TWO;		; Если результат равен нулю, перейти к метке 'TWO'

	; Занесение второго операнда, увеличенного на 1, в выходной порт 30h
	INR C		; Инкремент второго операнда
	MOV A, C	; Передача содержимого регистра C в аккумулятор
	JMP RES		; Переход к метке 'RES'

	; Занесение первого операнда, увеличенного на 1, в выходной порт 30h
ONE:	INR B		; Инкремент первого операнда
	MOV A, B	; Передача содержимого регистра B в аккумулятор
	JMP RES		; Переход к метке 'RES'

	; Занесение значения 0FFh в выходной порт 30h		
TWO:  	MVI A, 0FFh	; Занесение значения 0FFh в аккумулятор
RES:  	OUT 30h		; Вывод содержимого аккумулятора в порт 30h
END:  	NOP		; Метка завершения программы
