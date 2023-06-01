/*
В базе данных MS SQL Server есть продукты и категории. 
Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. 
Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». 
Если у продукта нет категорий, то его имя все равно должно выводиться.
*/

create table product
(
	id uniqueidentifier not null,
	name nvarchar(255) not null,
	constraint pk_product primary key(id)
);

create table category
(
	id uniqueidentifier not null,
	name nvarchar(255) not null,
	constraint pk_category primary key(id)
);

create table product_to_сategory
(
	product_id uniqueidentifier not null,
	category_id uniqueidentifier not null,
	constraint pk_product_to_category primary key (product_id, category_id),
	constraint fk_product_id foreign key (product_id) references product(id),
	constraint fk_category_id foreign key (category_id) references category(id)
);

insert into product
values
(newId(), 'Blender'),
(newId(), 'Washing machine'),
(newId(), 'Car'),
(newId(), 'Chocolate bar'),
(newId(), 'Frog');

insert into category
values
(newId(), 'Home appliances'),
(newId(), 'Vehicle'),
(newId(), 'For children'),
(newId(), 'Sweets');

insert into product_to_сategory
values
((select id from product where name = 'Blender'), (select id from category where name = 'Home appliances')),
((select id from product where name = 'Washing machine'), (select id from category where name = 'Home appliances')),
((select id from product where name = 'Car'), (select id from category where name = 'Vehicle')),
((select id from product where name = 'Chocolate bar'), (select id from category where name = 'For children')),
((select id from product where name = 'Chocolate bar'), (select id from category where name = 'Sweets'));

select p.Name, c.Name
from product p
left join product_to_сategory p_to_c on p_to_c.product_id = p.id
left join category c on c.id = p_to_c.category_id
order by p.name asc;