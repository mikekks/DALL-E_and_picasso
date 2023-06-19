# DALL-E And Picasso
> AI가 생성한 이미지 맞추기 게임

## Index
  - [Overview](#overview) 
  - [Database](#database)
  - [DALL-E](#dall-e)
  - [Getting Started](#getting-started)
  - [Program](#program)
  - [Point](#point)
  - [Contributing](#contributing)
  - [Reference](#reference)

## Overview
### Team Build
- 2023년 1학기 응용소프트웨어실습 (2023-03-12 ~ 2023-06-14)</br>
- 스피드게임 모티브로 `C# (.Net Core 3.1, .Net Framework 4.7.2)`, `MySQL`,`DALL-E API`를 사용한</br>
**AI가 생성한 이미지 맞추기 게임** 팀프로젝트 입니다.

### Git Convention 
1. 작업 하기 전, push 하기 전 [git pull] 생활화 하기
2. Mark
- [Add] : 새로운 기능 추가
- [Update] : 기능 개선
- [Delete] : 기능 삭제

## Database


### 테이블 생성
##### sql
``` sql
use mysql;
CREATE DATABASE test28;
use test28;

CREATE TABLE `Users` (
  `userId` VARCHAR(100) PRIMARY KEY NOT NULL,
  `roomId` VARCHAR(100),
  `password` VARCHAR(100),
  `name` VARCHAR(100),
  `identificationNumber` VARCHAR(100) UNIQUE,
  `recovery_Q` VARCHAR(100),
  `recovery_A` VARCHAR(100),
  `ready` BOOLEAN,
  `Tier` VARCHAR(100),
  `regDate` DATETIME
);
CREATE TABLE `Dalle` (
  `roomId` VARCHAR(100) NOT NULL,
  `QId` INT,
  `imageUrl` VARCHAR(10000),
  `keyword_1` VARCHAR(100),
  `keyword_2` VARCHAR(100),
  `keyword_3` VARCHAR(100),
  `keyword_4` VARCHAR(100),
  `keyword_5` VARCHAR(100),
  `keyword_6` VARCHAR(100),
  PRIMARY KEY (`roomId`, `QId`)
);
CREATE TABLE `Rooms` (
  `roomId` VARCHAR(100) PRIMARY KEY NOT NULL,
  `userId` VARCHAR(100) NOT NULL,
  `nowPlaying` BOOLEAN,
  `currentNum` INT,
  `totalNum` INT,
  `level` INT,
  `Round` INT
);
CREATE TABLE `Chat` (
  `roomId` VARCHAR(100) NOT NULL,
  `userId` VARCHAR(100) NOT NULL,
  `chat_date` DATETIME NOT NULL,
  `chat` VARCHAR(100),
  `data_length` INT,
  PRIMARY KEY (`roomId`, `userId`, `chat_date`)
);
CREATE TABLE `Records` (
  `userId` VARCHAR(100) NOT NULL,
  `roomId` VARCHAR(100) NOT NULL,
  `tryCount` INT,
  `correctCount` INT,
  PRIMARY KEY (`userId`, `roomId`)
);
ALTER TABLE `Users` ADD FOREIGN KEY (`roomId`) REFERENCES `Rooms` (`roomId`);
ALTER TABLE `Chat` ADD FOREIGN KEY (`userId`) REFERENCES `Users` (`userId`);
ALTER TABLE `Chat` ADD FOREIGN KEY (`roomId`) REFERENCES `Rooms` (`roomId`);
ALTER TABLE `Dalle` ADD FOREIGN KEY (`roomId`) REFERENCES `Rooms` (`roomId`);
ALTER TABLE `Rooms` ADD FOREIGN KEY (`userId`) REFERENCES `Users` (`userId`);
ALTER TABLE `Records` ADD FOREIGN KEY (`userId`) REFERENCES `Users` (`userId`);
ALTER TABLE `Records` ADD FOREIGN KEY (`roomId`) REFERENCES `Rooms` (`roomId`);
```

#### Users Table
![user](https://github.com/mikekks/DALL-E_and_picasso/assets/74387813/cd6f2559-0158-40a2-9de7-1fb50a5127ea)

#### Rooms Table
![room](https://github.com/mikekks/DALL-E_and_picasso/assets/74387813/5a8a904c-6721-4367-acb9-a7ff75532541)</br>
Users, Dalle, Records, Chat 테이블과의 관계를 roomId 외래키를 통해 설정하였습니다.

#### Dalle Table
![dalle](https://github.com/mikekks/DALL-E_and_picasso/assets/74387813/dff44860-9c12-429b-b6a4-2bf38c9b0e70)

#### Records Table
![record](https://github.com/mikekks/DALL-E_and_picasso/assets/74387813/17b4b697-a257-470b-b011-7ad319454336)

#### ER-diagram 구조
<img width="836" alt="스크린샷 2023-06-15 오전 11 25 45" src="https://github.com/mikekks/DALL-E_and_picasso/assets/100754581/f33e63aa-3aea-4b05-b2fd-8091a2009ae4">


## DALL-E

#### 달리 API란?
<div style="display:flex">
    <img src="https://github.com/mikekks/DALL-E_and_picasso/assets/74387813/61c78775-d44c-49c6-977e-140f89488b3f" alt="Image 1" width="400">
    <img src="https://github.com/mikekks/DALL-E_and_picasso/assets/74387813/d0fea333-34bf-484b-844f-2df8e5a8d428" alt="Image 2" width="600">
</div>
DALL-E API는 OpenAI에서 제공하는 인공지능 모델인 DALL-E에 접근하여</br>
이미지 생성과 관련된 기능을 사용할 수 있는 인터페이스입니다.

## Getting Started
#### 프로그램 실행을 위한 사전 준비 작업은 다음과 같습니다.
#### 1. MySql 설치(MacOS)
#### 기본 설치경로 유무 확인
```
cd /usr/local/mysql 
```
#### 2. MySql 상태 확인
```
netstat -an |grep LISTEN   
netstat -an |grep 3306     
netstat -an |grep mysql 
```
#### 3. 터미널에서 MySql 상태 확인
```
./mysql -u testId -p testPw
```
#### 4. MySql 데이터베이스 목록 확인
```
mysql> SHOW DATABASES;
```
#### 4. Database 생성 및 사용
```
use mysql;
CREATE DATABASE test18;
use test18;
```

## Program  

#### 1.회원가입</br>
![ezgif com-video-to-gif (6)](https://github.com/mikekks/DALL-E_and_picasso/assets/74387813/6baa46f7-0cc5-46cb-a8e5-a1f1c6b01f00)
<img width="402" alt="스크린샷 2023-06-19 오후 1 42 31" src="https://github.com/mikekks/DALL-E_and_picasso/assets/100754581/92a5c248-44c2-4f67-8729-d479e980686b">

#### 2. 로그인</br>
![ezgif com-video-to-gif (8)](https://github.com/mikekks/DALL-E_and_picasso/assets/74387813/690c8260-5ee0-400c-b4d6-39e2d1be84e0)

#### 3.아이디 찾기</br>
![ezgif com-video-to-gif (5)](https://github.com/mikekks/DALL-E_and_picasso/assets/74387813/3412dcbc-f800-479d-ae6f-ade4bd70a1da)

#### 4.비밀번호 재 설정하기</br>
![ezgif com-video-to-gif (4)](https://github.com/mikekks/DALL-E_and_picasso/assets/74387813/2004a522-360b-47fd-af5a-7d0da0cd1e21)

#### 5.비밀번호 찾기 실패</br>
![ezgif com-video-to-gif (3)](https://github.com/mikekks/DALL-E_and_picasso/assets/74387813/483ba74f-1133-4b5a-b565-00a46c7b272a)

#### 6.내 정보 확인하기</br>
![ezgif com-video-to-gif](https://github.com/mikekks/DALL-E_and_picasso/assets/74387813/60f95f7a-c681-47ec-b302-e8e0f86ff26d)

#### 7.방 선택 후 진입하기</br>
![ezgif com-video-to-gif (2)](https://github.com/mikekks/DALL-E_and_picasso/assets/74387813/dbd5e5d1-7cae-497b-a1c4-c2668f398fde)

#### 8.만들어진 방 리스트 불러오기</br>
![ezgif com-video-to-gif (1)](https://github.com/mikekks/DALL-E_and_picasso/assets/74387813/f1b5b1e2-9b8e-4951-8350-62bc07a13176)

#### 9.회원탈퇴</br>
![ezgif com-video-to-gif (7)](https://github.com/mikekks/DALL-E_and_picasso/assets/74387813/e73ff8fb-64ea-47e7-9005-273f79b3a127)

## Point
### 1. 외래키 제약 조건 활용
##### a. 데이터 일관성 유지 - 잘못된 데이터 입력이나 데이터 불일치로 인한 문제를 방지하였습니다.
##### b. 참조 무결성 보장 - 해당 레코드를 참조하는 다른 테이블의 데이터가 자동으로 일치하도록 하였습니다.
##### c. 관계 파악과 쿼리 효율성 - 데이터 모델을 간략화 하고, 관련 데이터를 효과적으로 조회할 수 있습니다.
### 2. SHA-256 알고리즘 적용
##### a. 안전한 암호화 - 단방향 해시 함수를 적용하여 고정 길이의 해시값으로 변환하였습니다.
##### b. 보안 강화 - 해시 값은 입력 데이터의 일부가 변경되어도 완전히 다른 값으로 변하기 때문에 데이터의 무결성을 보존합니다.
##### c. 속도와 효율성 - 개인정보의 암호화와 비교 검증 과정을 빠르고 효율적으로 수행할 수 있습니다.
### 3. DALL-E API 사용
##### a. 창의적이고 다양한 이미지 생성 - 다양한 랜덤 이미지를 자동으로 생성하여 게임의 즐거움과 흥미를 높였습니다.
##### b. 실시간 이미지 생성 - 동적 요소에 반응하고, 사용자에게 다양한 시각적인 경험을 제공합니다.


## Contributing
1. (https://github.com/mikekks/DALL-E_and_picasso)을 Fork합니다.
2. (`git checkout -b feature/fooBar`) 명령어로 새 Branch를 만드세요.
3. (`git commit -am 'Add some fooBar'`) 명령어로 Commit하세요.
4. (`git push origin feature/fooBar`) 명령어로 Branch에 Push하세요.

## Reference
- [사내 채팅 프로그램 팀프로젝트](https://github.com/KwDrama/OST)
- [WinForm에 MySQL 연동하기](https://dibrary.tistory.com/86)
- [MySQL DB 연동을 통해 간단한 로그인 및 회원가입 폼 만들기](https://acredev.tistory.com/21)

