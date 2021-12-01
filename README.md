# LP-IS-Taxopark
## Problem Description
It is necessary to develop an information system (IS) for the taxi dispatch service. The system must contain information about the cars indicated in the taxi company and orders made by the cars. 

## Functional Requirements
The dispatcher (user) must be able to:
-	Create, modify, delete, view orders. Each order must contain the following information:
    -	A order's date/time;
    -	A order's completion date/time;
    -	A customer information (full name, phone number);
    -	An address and GPS coordinates of dispatch;
    -	A destination address and GPS coordinates;
    -	A car;
    -	An order status (pending, in progress, completed). 
-	Create, modify, delete, view vehicle data:
    -	A car's registration number;
    -	A car model;
    -	A driver full name.

### Main Business flows
-	A just created order is become in "pending" state. The transition from "pending" state is possible only to the "in progress" state and only if a car serving this order is specified. An order can go to the "completed" state only from the "in progress" state and when the order's completion date/time is specified.
-	The mandatory fields for an order are: date/time of order, customer information, address and GPS coordinates of dispatch, address and GPS coordinates of destination.
-	The mandatory field for a car is: registration number.
----	
## Постановка задачи
Необходимо  разработать  информационную  систему  (ИС) для  диспетчерской службы такси. Система должна содержать в себе информацию об автомобилях, числящихся в таксопарке, и заказах, выполняемых автомобилями. 

## Функциональность системы (требования)
Диспетчер (пользователь) должен иметь возможность:
-	Создавать,  изменять,  удалять,  просматривать  заказы. Каждый заказ должен содержать следующую информацию:
    -	дата/время заказа;
    -	дата/время выполнения заказа;
    -	информация о клиенте (имя, телефон);
    -	адрес и GPS координаты отправки;
    -	адрес и GPS координаты назначения;
    -	автомобиль;
    -	состояние заказа (в ожидании, выполняется, выполнен). 
-	Создавать, изменять, удалять, просматривать данные об автомобилях, а именно:
    -	номерной знак;
    -	марка автомобиля;
    -	ФИО водителя.

## В ходе работы накладываются следующие ограничения:
-	Только что оформленный заказ находится в состоянии «в ожидании». Переход  из  этого  состояния  возможен  только  в  состояние  «выполняется»  и только  если  указан  автомобиль,  обслуживающий  данный  заказ.  В  состояние «выполнен»  заказ  может  перейти  только  из  состояния  «выполняется»  и  при указании даты/времени выполнения заказа.
-	Обязательными полями для заказа являются: дата/время заказа, информация о клиенте, адрес и координаты отправки, адрес и координаты назначения.
-	Обязательным полем для автомобиля является: номерной знак.
