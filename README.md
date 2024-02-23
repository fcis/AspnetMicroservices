# AspnetMicroservice
Asp net8 Microservices
Building Microservices on .Net8 which used Asp.Net Web API, Docker, RabbitMQ,Ocelot API Gateway, MongoDB,Redis,SqlServer

Docker Compose Commands 
List all containers (only IDs)
docker ps -aq
Stop all running containers
docker stop $(docker ps -aq)
Remove all containers
docker rm $(docker ps -aq)
Remove all images
docker rmi $(docker images -q)
Remove all none images
docker system prune

-- You can also run all with copy paste

docker ps -aq
docker stop $(docker ps -aq)
docker rm $(docker ps -aq)
docker rmi $(docker images -q) -f
docker system prune

Close all dockers and run with below command on that location;

	docker-compose -f docker-compose.yml -f docker-compose.override.yml up --build
	or
	docker-compose -f docker-compose.yml -f docker-compose.override.yml up -d
	docker-compose -f docker-compose.yml -f docker-compose.override.yml down
