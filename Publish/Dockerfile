# 基于https://github.com/7jcoding/chasir:v1.0构建Docker Image
FROM https://github.com/7jcoding/chasir:v1.0
 
# 进入docker中的/var/www/目录
RUN cd /var/www/
 
# 创建DockerWebAPI目录
RUN mkdir chasir
 
# 设置工作路径
WORKDIR /var/www/chasir
 
# 将当前文件夹下的所有文件全部复制到工作目录
COPY *.* ./
 
# 向外界暴露5000端口
EXPOSE 5000
 
# 执行dotnet chasir.dll命令
CMD ["dotnet", "chasir.dll"]