# Expertsoft5

curl --location 'https://localhost:7296/Config/' \
--header 'Authorization: YOUR_SECRET_CODE' \
--header 'Content-Type: application/json' \
--data '{
    "CompanyId": "27283A43-F307-4143-AF42-115946C308FD"
}'


curl --location 'https://localhost:7296/Work/' \
--header 'Authorization: YOUR_SECRET_CODE' \
--header 'Content-Type: application/json' \
--data '{
    "Plate": "34TR34"
}'


curl --location 'https://localhost:7296/WorkResult/' \
--header 'Authorization: YOUR_SECRET_CODE' \
--header 'Content-Type: application/json' \
--data '{
    "CustomNumber": "53435"
}'
