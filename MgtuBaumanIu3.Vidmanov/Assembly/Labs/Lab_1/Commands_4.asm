; Включения светодиодов выходного устройства, если число, записанное во входном устройстве,
; не содержит "1" в 3 и содержит ее в 5 разряде

$ADR 0000h		; Адрес начала программы

	; Занесение исходных данных в регистр
	IN 20h		; Чтение данных из порта 20h в аккумулятор
	MOV B, A	; Передача содержимого аккумулятора в регистр B

	; Проверка на соответствие данных условию 1
	ANI 100b	; Выполнить логическое умножение содержимого аккумулятора на число 100b
	JZ ONE		; Если результат равен нулю, перейти к метке 'ONE'
	JMP END		; Переход к метке 'END'

	; Проверка на соответствие данных условию 2
ONE:	MOV A, B	; Передача содержимого регистра B в аккумулятор
	ANI 10000b	; Выполнить логическое умножение содержимого аккумулятора на число 10000b
	JZ END		; Если результат равен нулю, перейти к метке 'END'

	; В случае выполнения условий 1 и 2 зажечь светодиоды
	MVI A, 0FFh	; Занесение значения 0FFh в аккумулятор
	OUT 30h		; Вывод содержимого аккумулятора в порт 30h

END:	NOP		; Метка завершения программы
