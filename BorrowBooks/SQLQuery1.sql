create table users(
user_id int identity(1,1) primary key,
user_name varchar(100) not null,
mail_address varchar(100) not null,
password varchar(20) not null,
phone char(13) not null
);

create table books(
book_id int identity(1,1) primary key,
title varchar(100) not null,
author varchar(100) not null,
genre varchar(20) not null,
lend_user_id int foreign key references users(user_id),
lend_date date
);


insert into users(user_name,mail_address,password,phone) values
('小友瑞貴','o-mizuki@outlook.jp','o-mizuki0820','080-1234-5678'),
('水間ほのか','m-honoka@outlook.jp','m-honoka0208','090-1234-5678');

insert into books(title,author,genre) values
('夢をかなえるゾウ','水野敬也','自己啓発'),
('夢をかなえるゾウ２','水野敬也','自己啓発'),
('夢をかなえるゾウ３','水野敬也','自己啓発'),
('嫌われる勇気 自己啓発の源流「アドラー」の教え','岸見一郎 古賀史健','心理学'),
('幸せになる勇気 自己啓発の源流「アドラー」の教えⅡ','岸見一郎 古賀史健','心理学'),
('ONE PIECE 104','尾田栄一郎','少年コミック'),
('ONE PIECE 103','尾田栄一郎','少年コミック'),
('ONE PIECE 102','尾田栄一郎','少年コミック'),
('ONE PIECE 101','尾田栄一郎','少年コミック'),
('ONE PIECE 100','尾田栄一郎','少年コミック'),
('戦国の忍び 司馬遼太郎・傑作短篇選','司馬遼太郎','歴史'),
('戦国の女たち 司馬遼太郎・傑作短篇選','司馬遼太郎','歴史'),
('完全無欠の問題解決ー－－不確実性を乗り越える７ステップアプローチ','チャールズ・コン ロバート・マクリーン','ビジネス・経済'),
('構造化思考トレーニング コンサルタントが必ず身に着ける定番スキル','中島将貴','ビジネス・経済'),
('マッピング思考ー－人には見えてくる「メタ論理トレーニング」','ジュリア・ガレフ 児島修','哲学・思想')
;