-- 1 Клиенти и техните адреси за всички клиенти, които се намират в САЩ и щата Калифорния
SELECT * FROM CUSTOMERS
WHERE COUNTRY = "USA" AND STATE = "CA";

-- 2 Клиенти и техните адреси за всички клиенти, които се намират в САЩ и щата Калифорния и имат кредитен лимит над 100000
SELECT * FROM CUSTOMERS
WHERE COUNTRY = "USA" AND STATE = "CA" AND CREDITLIMIT > 100000;

-- 3 Клиенти и техните адреси за всички клиенти, които се намират в САЩ или Канада
SELECT * FROM CUSTOMERS
WHERE COUNTRY = "USA" OR COUNTRY = "CANADA";

-- 4 Клиенти и техните адреси за всички клиенти, които се намират в САЩ или Канада и имат кредитен лимит над 100 000
SELECT * FROM CUSTOMERS
WHERE (COUNTRY = "USA" OR COUNTRY = "CANADA" )AND CREDITLIMIT > 100000;

-- 5 Продуктите, които имат налично количество между 7000 и 10 000 броя и имат продажна цена над 50;
SELECT * FROM PRODUCTS
WHERE QUANTITYINSTOCK >7000 AND QUANTITYINSTOCK <10000 AND BUYPRICE>50;

-- 6 Продуктите, които са от продуктова линия Classic…. (с like)
SELECT * FROM PRODUCTS
WHERE PRODUCTLINE = "Classic Cars";

-- 7 Поръчките, направени след месец Юни 2004
SELECT * FROM ORDERS 
WHERE ORDERDATE>"2004-06-01";

-- 8 Поръчките, които имат еднакви дати за необходима доставка и доставна дата
SELECT * FROM ORDERS 
WHERE requireddate = shippeddate;

-- 9 Поръчките, които имат статус Изпратени и нямат коментар
SELECT * FROM ORDERS 
WHERE status="shipped" and comments is null;

-- 10 Поръчките, които имат статус Прекратени и имат коментар
SELECT * FROM ORDERS 
WHERE status="cancelled" and comments is not null ;

-- 11 Продуктите, които имат в описанието си думата “replica” (от таблицата productlines)
select productline from productlines
where textdescription like '%replica%';

-- 12 Служителите, които имат във фамилията си ‘on’
select firstName,lastname from employees
where lastname like '%on%';

-- 13 Служителите, които нямат във фамилията си ‘B’
select firstName,lastname from employees
where lastname not like '%B%';

-- 14 Служителите и държавите, в които се намират
select firstName,lastname,country from employees
join offices on employees.officeCode = offices.officeCode;

-- 15 Служителите, които работят в Австралия
select firstName,lastname from employees
join offices on employees.officeCode = offices.officeCode
where offices.country= "Australia";

-- 16 Поръчките, имената на клиентите, които са ги поръчали, датата на поръчка
SELECT ordernumber,customername,orderdate FROM CUSTOMERS 
JOIN orders ON ORDERS.CUSTOMERNUMBER = customers.customerNumber;

-- 17 Поръчките, номерата на продуктите и общите тотали за всеки продукт
SELECT ordernumber,productcode,priceeach*quantityordered FROM ORDERS 
JOIN ORDERDETAILS ON ORDERS.ordernumber = ORDERDETAILS.ordernumber;

-- 18 Имената на служителите и имената на техните отговорници
select employees.firstname,employees.lastname,e.firstname,e.lastname from employees
JOIN employees  e ON e.employeeNumber = employees.reportsTo;

-- 19 Имената на продуктите във всяка поръчка, както и имената на продуктовите линии (три таблици)
select distinct products.productname,productlines.productLine from products
join productlines on productlines.productLine = products.productLine
join orderdetails on orderdetails.productCode = products.productCode
join orders on orders.ordernumber = orderdetails.ordernumber;

-- 20 Имената на служителите и имената на клиентите, които обслужват, сортирани по име и фамилия на служител
select distinct employees.firstName,employees.lastName from employees
join customers on customers.salesRepEmployeeNumber = employees.employeeNumber
order by employees.firstName,employees.lastName desc;

-- 21 Имената на клиентите, имената на контактните лица, номерата на чековете, датите на плащане, сортирани по име на клиент и дата
select distinct customername,contactFirstName,contactLastName,checkNumber,paymentdate from customers
join payments on payments.customerNumber = customers.customerNumber
order by customername,paymentdate desc;

-- 22 Имената на клиентите, имената на контактните лица, номерата на чековете, платената сума, сортирани по име на клиент и платена сума
select distinct customername,contactFirstName,contactLastName,checkNumber,amount from customers
join payments on payments.customerNumber = customers.customerNumber
order by customername,amount desc;

-- 23 Номерата на чековете и сумите, за всички плащания, направени от Франция, САЩ и Полша
select checknumber, amount, country from payments, customers
where customers.customernumber = payments.customernumber and country in ('France', 'USA', 'Poland');

-- 24 Изпратените поръчки и имената на продуктите в тях, сортирани по номер на поръчка
select orders.ordernumber, orders.status, productname from orders, products, orderdetails
where (orderdetails.ordernumber = orders.ordernumber and products.productcode = orderdetails.productcode) and orders.status = 'shipped'
order by orders.ordernumber;

-- 25 Списък на държавите, в които има офиси (да няма повтарящи се записи)
select distinct country from offices;

-- 26 Списък на държавите, в които има клиенти (да няма повтарящи се записи)
select distinct country from customers;

-- 27 Номерата на поръчките, имената на клиентите и имената на служителите, свързани със съответната поръчка
select ordernumber, customername, firstname, lastname from orders, customers, employees
where customers.customernumber = orders.customernumber and employees.employeenumber = customers.salesrepemployeenumber;

-- 28 Списък на клиентите, които имат отваряща и затваряща скоба в телефонния си номер
select customername, phone from customers
where phone like '%(%)%';

-- 29 Списък от имената на служителите, които работят в офиси, в чийто адрес се среща тире (обърнете внимание, че адресът е в две колони)
select customername, addressline1, addressline2 from customers
where addressline1 like '%-%' or addressline2 like '%-%';

-- 30 Продуктовите линии и продуктите в тях, за които на трета позиция в колоната productScale се намира цифрата 7 (виж документация за използване на wildcard символи в like)
select productline, productname, productscale from products
where productscale like '__7%';

-- 31 Имената на клиентите, техните телефони и държава, ако нямат нито една направена поръчка
SELECT CUSTOMERNAME,PHONE,country FROM customers
left JOIN ORDERS ON  customers.customerNumber = oRDERS.CUSTOMERNUMBER
WHERE ORDERNUMBER IS NULL;

-- 32 Има ли офиси, в които няма служители?
select * from offices
join employees on employees.officecode = offices.officecode
where employees.officecode  is null;

-- 33 Продуктите, които не са поръчвани никога
select * from products
left join orderdetails on orderdetails.productCode = products.productCode
where orderdetails.quantityOrdered is null;

-- 34 Клиентите, които имат поръчки, но нямат плащания
select * from orders
join customers on customers.customerNumber = orders.customerNumber
join payments on payments.customerNumber =  customers.customerNumber
where paymentDate is null;

-- 35 Клиентите, които имат плащания, но нямат поръчки
select * from orders
join customers on customers.customerNumber = orders.customerNumber
join payments on payments.customerNumber =  customers.customerNumber
where orderdate is null;

-- 36 Имената на служителите, които не работят с нито един клиент или с клиенти, които не са направили нито едно плащане
select * from employees
left join customers on customers.salesRepEmployeeNumber = employees.employeeNumber
join payments on payments.customerNumber =  customers.customerNumber
where paymentdate is null;

-- 37 Имената на клиентите и имената на продуктите, които са поръчвали
select distinct customerName,productname   from customers
join orders on customers.customerNumber = orders.customerNumber
join orderdetails on orderdetails.orderNumber = orders.orderNumber
join products on products.productCode = orderdetails.productCode;

-- 38 Номерата на поръчките, датата на поръчка и описанието на продуктовите серии на продуктите в тях, без дублиране на записите в резултата
select distinct orders.ordernumber, orders.orderdate, productlines.textdescription from orders
left join orderdetails on orders.ordernumber = orderdetails.ordernumber
inner join products on products.productcode = orderdetails.productcode
inner join productlines on productlines.productline = products.productline;

-- 39 Имената и фамилиите на служителите, държавите, в които са техните офиси и имената и държавата на клиентите, с които работят
select firstname, lastname, offices.country, customers.customername, customers.country from employees
left join offices on employees.officecode = offices.officecode
left join customers on employees.employeenumber = customers.salesrepemployeenumber;

-- 40 Имената и фамилиите на служителите, държавите, в които са техните офиси и имената и държавата на клиентите, с които работят. Само за тези, за които клиенти и служители са в една и съща държава
select firstname, lastname, offices.country, customers.customername, customers.country from employees
left join offices on employees.officecode = offices.officecode
left join customers on employees.employeenumber = customers.salesrepemployeenumber
where offices.country = customers.country;

 













