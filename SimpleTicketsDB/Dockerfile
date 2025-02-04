# ベースイメージ
FROM postgres:15

# 環境変数でデフォルトのユーザー、パスワード、データベースを設定
ENV POSTGRES_USER=admin
ENV POSTGRES_PASSWORD=Password0!
ENV POSTGRES_DB=simple_tickets

# 初期化スクリプトをコンテナの /docker-entrypoint-initdb.d にコピー
COPY ./SimpleTicketsDB/ /docker-entrypoint-initdb.d/

# 権限
RUN chmod -R 755 /docker-entrypoint-initdb.d