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
![스크린샷 2023-05-29 오후 9 15 49](https://github.com/mikekks/DALL-E_and_picasso/assets/74387813/17c9da67-203c-4d73-8317-f6e267f9a9d9)

## DALL-E

## Getting Started

## Program  ++ 홈페이지 진입, 게임 도중, 게임 결과화면 추가하기

#### 1.회원가입</br>
![ezgif com-video-to-gif (6)](https://github.com/mikekks/DALL-E_and_picasso/assets/74387813/6baa46f7-0cc5-46cb-a8e5-a1f1c6b01f00)

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

## Contributing
1. (https://github.com/mikekks/DALL-E_and_picasso)을 Fork합니다.
2. (`git checkout -b feature/fooBar`) 명령어로 새 Branch를 만드세요.
3. (`git commit -am 'Add some fooBar'`) 명령어로 Commit하세요.
4. (`git push origin feature/fooBar`) 명령어로 Branch에 Push하세요.

## Reference


