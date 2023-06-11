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
- 스피드게임 모티브로 `C# (.Net Core 3.1, .Net Framework 4.7.2)`, `MySQL`,`DALL-E API`를 사용한 
**AI가 생성한 이미지 맞추기 게임** 팀프로젝트 입니다.

### Git Convention 
1. 작업 하기 전, push 하기 전 [git pull] 생활화 하기
2. Mark
- [Add] : 새로운 기능 추가
- [Update] : 기능 개선
- [Delete] : 기능 삭제

## Database
#### 테이블 생성
##### sql
``` sql
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
  `Round` INT,
  `Chat` BLOB
);
CREATE TABLE `Chat` (
  `roomId` VARCHAR(100) NOT NULL,
  `userId` VARCHAR(100) NOT NULL,
  `chat_date` DATETIME UNIQUE,
  `data` BLOB,
  `data_length` INT,
  PRIMARY KEY (`roomId`, `userId`)
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

#### User Table
![user](https://github.com/mikekks/DALL-E_and_picasso/assets/74387813/cd6f2559-0158-40a2-9de7-1fb50a5127ea)

#### Room Table
![room](https://github.com/mikekks/DALL-E_and_picasso/assets/74387813/5a8a904c-6721-4367-acb9-a7ff75532541)

#### Dealle Table
![dalle](https://github.com/mikekks/DALL-E_and_picasso/assets/74387813/dff44860-9c12-429b-b6a4-2bf38c9b0e70)

#### Record Table
![record](https://github.com/mikekks/DALL-E_and_picasso/assets/74387813/17b4b697-a257-470b-b011-7ad319454336)

#### MySql 연동 함수
|Index|Table|Function|Description|
|------|---|---|---|
|1|User|signUp|회원가입|
|1-1||checkDuplicateUserId|아이디 중복확인|
|1-2||findUserId|아이디 찾기|
|1-3||findPassword|비밀번호 찾기|
|1-4||updatePassword|비밀번호 재 설정|
|1-5||unRegister|회원탈퇴|
|1-6|Login|login|로그인|
|2-1|Record|getRecords|내 기록 가져오기|
|3|Room|getRoomsList|방 리스트 가져오기|
|3-1||makeNewRoom|방 만들기|
|2-2||findUserId|아이디 찾기|
|2-2||findUserId|아이디 찾기|
|2-2||findUserId|아이디 찾기|
|2-2||findUserId|아이디 찾기|


#### ER-diagram 구조
![스크린샷 2023-05-29 오후 9 15 49](https://github.com/mikekks/DALL-E_and_picasso/assets/74387813/17c9da67-203c-4d73-8317-f6e267f9a9d9)

## DALL-E

## Database
## Getting Started
## Program
## Point
## Contributing
## Reference


