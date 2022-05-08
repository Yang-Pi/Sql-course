-- Выведите название продавца, который продал товаров на наибольшую сумму пользователям из Краснодара. 
-- Учтите, что вас интересуют транзакции тольско со статусом compeleted.

-- Запрос должен возвращать таблицу из двух полей и одной строки. 
-- В первом поле выведите название продавца и назовите его name. 
-- Во втором поле выведите общую сумму продаж и назовите его total_sales.

SELECT S.name, SUM(P.price) total_sales
FROM products P
    JOIN transactions T ON T.product_id = P.id
    JOIN users U ON T.user_id = U.id
    JOIN cities C ON U.city_id = C.id
    JOIN sellers S on P.seller_id = S.id
WHERE C.name = 'Краснодар' AND T.status = 'completed'
GROUP BY S.Id
ORDER BY total_sales DESC
LIMIT 1