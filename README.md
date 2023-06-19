# DALL-E And Picasso
> AI가 생성한 이미지를 맞추는 스피드 게임

## Index
  - [Overview](#overview)
  - [Architecture](#architecture) 
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
**AI가 생성한 이미지를 맞추는 스피드 게임** 팀프로젝트 입니다.

### Git Convention 
1. 작업 하기 전, push 하기 전 [git pull] 생활화 하기
2. Mark
- [Add] : 새로운 기능 추가
- [Update] : 기능 개선
- [Delete] : 기능 삭제

## Architecture
<img width="980" alt="스크린샷 2023-06-19 오후 1 52 17" src="https://github.com/mikekks/DALL-E_and_picasso/assets/100754581/79bb8ce8-51ef-41e6-a6a1-e077751d4b81">


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

##### 업데이트된 UI 
<img width="402" alt="스크린샷 2023-06-19 오후 1 42 31" src="https://github.com/mikekks/DALL-E_and_picasso/assets/100754581/92a5c248-44c2-4f67-8729-d479e980686b">

#### 2. 로그인</br>
![ezgif com-video-to-gif (8)](https://github.com/mikekks/DALL-E_and_picasso/assets/74387813/690c8260-5ee0-400c-b4d6-39e2d1be84e0)

##### 업데이트된 UI 
<img width="704" alt="스크린샷 2023-06-19 오후 1 45 08" src="https://github.com/mikekks/DALL-E_and_picasso/assets/100754581/3016008a-d757-45ab-8b4d-1ff0b1e2792b">

#### 3.아이디 찾기</br>
![ezgif com-video-to-gif (5)](https://github.com/mikekks/DALL-E_and_picasso/assets/74387813/3412dcbc-f800-479d-ae6f-ade4bd70a1da)

##### 업데이트된 UI 
<img width="408" alt="스크린샷 2023-06-19 오후 1 45 39" src="https://github.com/mikekks/DALL-E_and_picasso/assets/100754581/9bae42a2-d912-4aa7-9045-b03312e39af7">

#### 4.비밀번호 재 설정하기</br>
![ezgif com-video-to-gif (4)](https://github.com/mikekks/DALL-E_and_picasso/assets/74387813/2004a522-360b-47fd-af5a-7d0da0cd1e21)

##### 업데이트된 UI 
<img width="415" alt="스크린샷 2023-06-19 오후 1 46 03" src="https://github.com/mikekks/DALL-E_and_picasso/assets/100754581/005f18d8-8307-4e02-82d4-8ef76e9a7d96">

#### 5.비밀번호 찾기 실패</br>
![ezgif com-video-to-gif (3)](https://github.com/mikekks/DALL-E_and_picasso/assets/74387813/483ba74f-1133-4b5a-b565-00a46c7b272a)

#### 6.만들어진 방 리스트 불러오기</br>
<img width="693" alt="스크린샷 2023-06-19 오후 1 47 57" src="https://github.com/mikekks/DALL-E_and_picasso/assets/100754581/b01a6780-4532-4765-b001-7606c263523a">

#### 7.방 만들기</br>
<img width="570" alt="스크린샷 2023-06-19 오후 1 48 32" src="https://github.com/mikekks/DALL-E_and_picasso/assets/100754581/bc553172-8af3-437d-b21d-ef988ed2931f">

#### 8.인게임 화면</br>
<img width="1246" alt="스크린샷 2023-06-19 오후 1 49 25" src="https://github.com/mikekks/DALL-E_and_picasso/assets/100754581/1b8d5033-99d7-4131-a1d7-f471696964a5">

<img width="1251" alt="스크린샷 2023-06-19 오후 1 50 01" src="https://github.com/mikekks/DALL-E_and_picasso/assets/100754581/1e2ea304-cbcf-4425-ab1f-27f33898d0e9">

#### 9.게임 결과 화면</br>
<img width="1243" alt="스크린샷 2023-06-19 오후 1 50 36" src="https://github.com/mikekks/DALL-E_and_picasso/assets/100754581/ec92c2eb-2dc3-4635-9d42-b80b00d0de97">

#### 10.회원탈퇴</br>
![ezgif com-video-to-gif (7)](https://github.com/mikekks/DALL-E_and_picasso/assets/74387813/e73ff8fb-64ea-47e7-9005-273f79b3a127)

## Point
### 1.Real-time Game
##### a. 게임의 실시간 상태를 DB에 기록
##### b. 모든 클라이언트가 실시간으로 동기화
### 2. DB Normalization
##### a. 함수적 종속성 유지 - 종속성 유지를 통해 쿼리 비용 최적화
##### b. 데이터 중복 및 null 완화 - 수정, 삽입, 삭제를 보다 원활히 가능
### 3.UI
##### a. 메이플스토리의 영감을 받은 게임같은 UI
### 4. SHA-256 알고리즘 적용
##### a. 암호화 - 단방향 해시 함수를 적용하여 고정 길이의 해시값으로 변환
##### b. 보안 강화 - 해시 값으로 본래 값 역추적 불가
### 5. DALL-E API 사용
##### a. 창의적이고 다양한 이미지 생성 - 다양한 랜덤 이미지를 자동으로 생성하여 게임의 즐거움과 흥미를 높임
##### b. 실시간 이미지 생성 - 동적 요소에 반응하고, 사용자에게 다양한 시각적인 경험 제공


## Contributing
1. (https://github.com/mikekks/DALL-E_and_picasso)을 Fork합니다.
2. (`git checkout -b feature/fooBar`) 명령어로 새 Branch를 만드세요.
3. (`git commit -am 'Add some fooBar'`) 명령어로 Commit하세요.
4. (`git push origin feature/fooBar`) 명령어로 Branch에 Push하세요.

## Reference
- [WinForm 공식 Docs](https://learn.microsoft.com/ko-kr/visualstudio/ide/create-csharp-winform-visual-studio?view=vs-2022)

