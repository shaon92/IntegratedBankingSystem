-- phpMyAdmin SQL Dump
-- version 4.7.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 14, 2022 at 05:52 PM
-- Server version: 10.1.24-MariaDB
-- PHP Version: 7.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `integratedbankingsystem`
--

-- --------------------------------------------------------

--
-- Table structure for table `tcustomer`
--

CREATE TABLE `tcustomer` (
  `id` int(11) NOT NULL,
  `custid` int(11) NOT NULL,
  `fullname` varchar(30) NOT NULL,
  `f_name` varchar(30) DEFAULT NULL,
  `m_name` varchar(30) DEFAULT NULL,
  `gender` varchar(10) NOT NULL,
  `dob` varchar(10) NOT NULL,
  `religion` varchar(10) DEFAULT NULL,
  `nid` int(20) NOT NULL,
  `tin` int(20) DEFAULT NULL,
  `email` varchar(40) DEFAULT NULL,
  `contact` varchar(15) NOT NULL,
  `address` varchar(200) NOT NULL,
  `profession` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tcustomer`
--

INSERT INTO `tcustomer` (`id`, `custid`, `fullname`, `f_name`, `m_name`, `gender`, `dob`, `religion`, `nid`, `tin`, `email`, `contact`, `address`, `profession`) VALUES
(1, 1, 'Md Shafiqul Alam', 'Late Md Samsul Alam', 'Late Samsun Nahar', 'Male', '2/10/1958', 'Islam', 154265975, 2147483647, 'shafiqul@gmail.com', '01732636187', 'House No 57, North Jatrabari, \r\nDhaka - 1204', 'Private Service'),
(2, 2, 'Md Sajidul Alam', 'Md Shafiqul Alam', 'Kaniz Rokeya Rina', 'Male', '7/16/1992', 'Islam', 280295409, 2147483647, 'shaonsajidu@gmail.com', '01680235344', 'House no 57, North Jatrabari, Dhaka - 1204', 'Private Service'),
(3, 3, 'Kaniz Rokeya', 'Lt. Md Qumruzzaman', 'Hasna Banu', 'Female', '5/9/1965', 'Islam', 2147483646, 0, '', '01732636188', 'House no 57, North Jatrabari, Dhaka - 1204', 'Housewife'),
(4, 4, 'Md Biplob Parvez', 'Rayhan Ali', 'Mrs. Rayhan Ali', 'Male', '3/29/1988', 'Islam', 2147483647, 2147483647, 'biplob/parvez@gmail.com', '01821114451', 'House no: 35, Uttara, Dhaka', 'Private Service'),
(5, 5, 'Md Tanvir Hafiz', 'Md Hafiz Uddin', 'Mrs. Lutfannesa', 'Male', '6/17/1987', 'Islam', 2147483647, 2147483647, 'tanvir.hafiz@gmail.com', '01682124778', 'House no 45, Dhanmondi - 26,\r\nDhaka', 'Businessman');

-- --------------------------------------------------------

--
-- Table structure for table `tdeposit`
--

CREATE TABLE `tdeposit` (
  `id` int(11) NOT NULL,
  `custid` int(11) NOT NULL,
  `acno` int(11) NOT NULL,
  `actitle` varchar(30) NOT NULL,
  `smsmobile` varchar(20) NOT NULL,
  `opndt` varchar(30) NOT NULL,
  `matamt` int(11) NOT NULL,
  `mdepamt` int(11) NOT NULL,
  `intr` double NOT NULL,
  `nod` int(11) NOT NULL,
  `nodp` int(11) NOT NULL,
  `linkSvAc` int(11) NOT NULL,
  `acbal` double NOT NULL,
  `nominee_name` varchar(30) DEFAULT NULL,
  `nominee_nid` int(17) DEFAULT NULL,
  `relation_nominee` varchar(30) DEFAULT NULL,
  `share_p` varchar(10) DEFAULT NULL,
  `dep_sts` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tdeposit`
--

INSERT INTO `tdeposit` (`id`, `custid`, `acno`, `actitle`, `smsmobile`, `opndt`, `matamt`, `mdepamt`, `intr`, `nod`, `nodp`, `linkSvAc`, `acbal`, `nominee_name`, `nominee_nid`, `relation_nominee`, `share_p`, `dep_sts`) VALUES
(1, 1, 20001, 'Md Shafiqul Alam', '01732636188', '3/5/2021', 108000, 3000, 7, 36, 34, 1001, 149000, 'Md Sajidul Alam', 2147483647, 'Father', '100%', 'open'),
(2, 2, 20002, 'Md Sajidul Alam', '01680235344', '3/5/2021', 90000, 2500, 6, 36, 36, 1002, 0, 'Kaniz Rokeya Rina', 1452148877, 'Mother', '100%', 'encashed'),
(3, 5, 20003, 'Md Tanvir Hafiz', '01682124778', '7/10/2021', 36000, 1000, 6, 36, 0, 1008, 0, 'Md Sajidul Alam', 2147483647, 'Brother', '100%', 'open');

-- --------------------------------------------------------

--
-- Table structure for table `tdeposittrn`
--

CREATE TABLE `tdeposittrn` (
  `id` int(11) NOT NULL,
  `batno` int(11) NOT NULL,
  `acno` int(11) NOT NULL,
  `trntyp` varchar(30) NOT NULL,
  `nod` int(11) DEFAULT NULL,
  `trnamt` double NOT NULL,
  `trndt` varchar(20) NOT NULL,
  `vcno` varchar(20) NOT NULL,
  `encacno` int(11) DEFAULT NULL,
  `trndes` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tdeposittrn`
--

INSERT INTO `tdeposittrn` (`id`, `batno`, `acno`, `trntyp`, `nod`, `trnamt`, `trndt`, `vcno`, `encacno`, `trndes`) VALUES
(1, 2001, 20001, 'Monthly Deposit', 1, 3000, '3/6/2021', 'V-1', NULL, 'First Deposit'),
(2, 2002, 20001, 'Monthly Deposit', 2, 6000, '3/6/2021', 'v-3', NULL, 'deposit'),
(3, 2003, 20001, 'Monthly Deposit', 20, 60000, '3/6/2021', 'v-1', NULL, 'dep'),
(7, 2004, 20002, 'Monthly Deposit', 16, 40000, '3/7/2021', 'v-76', NULL, 'deposit'),
(8, 2005, 20001, 'Monthly Deposit', 3, 9000, '5/7/2021', 'v-54', NULL, 'Monthly deposit'),
(9, 2006, 20001, 'Monthly Deposit', 4, 12000, '5/7/2021', '', NULL, ''),
(10, 2007, 20001, 'Monthly Deposit', 1, 50000, '5/7/2021', 'vc', NULL, ''),
(12, 2009, 20002, 'Monthly Deposit', 19, 47500, '6/11/2021', 'v-05', NULL, 'installment '),
(13, 2010, 20002, 'Monthly Deposit', 1, 2500, '6/11/2021', 'v-02', NULL, 'last installment'),
(14, 2011, 20002, 'Encashment', NULL, 106200, '6/11/2021', 'v-05', 1002, 'encashment'),
(15, 2012, 20001, 'Monthly Deposit', 3, 9000, '7/10/2021', 'dp-201', NULL, 'Three deposits');

-- --------------------------------------------------------

--
-- Table structure for table `tdep_expenditure`
--

CREATE TABLE `tdep_expenditure` (
  `id` int(11) NOT NULL,
  `batno` int(11) NOT NULL,
  `acno` int(11) NOT NULL,
  `amt` double NOT NULL,
  `year` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tdep_expenditure`
--

INSERT INTO `tdep_expenditure` (`id`, `batno`, `acno`, `amt`, `year`) VALUES
(2, 2011, 20002, 16200, '2021');

-- --------------------------------------------------------

--
-- Table structure for table `tloan`
--

CREATE TABLE `tloan` (
  `id` int(11) NOT NULL,
  `custid` int(11) NOT NULL,
  `actitle` varchar(30) NOT NULL,
  `acno` int(11) NOT NULL,
  `smsMobile` varchar(20) NOT NULL,
  `sancno` varchar(20) NOT NULL,
  `openDate` varchar(15) NOT NULL,
  `expiryDate` varchar(15) NOT NULL,
  `instAmt` double NOT NULL,
  `intrPinst` double NOT NULL,
  `sancAmt` double NOT NULL,
  `ftAmt` double NOT NULL,
  `noi` int(11) NOT NULL,
  `intr` double NOT NULL,
  `noip` int(11) NOT NULL DEFAULT '0',
  `calTyp` varchar(15) NOT NULL,
  `calPer` varchar(15) NOT NULL,
  `lnSts` varchar(15) NOT NULL DEFAULT 'R',
  `disbSts` varchar(15) NOT NULL DEFAULT 'N',
  `prFeeSts` varchar(15) NOT NULL DEFAULT 'N',
  `acbal` double NOT NULL DEFAULT '0',
  `guarantoName` varchar(30) NOT NULL,
  `guarantorNID` int(17) NOT NULL,
  `relGuarantor` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tloan`
--

INSERT INTO `tloan` (`id`, `custid`, `actitle`, `acno`, `smsMobile`, `sancno`, `openDate`, `expiryDate`, `instAmt`, `intrPinst`, `sancAmt`, `ftAmt`, `noi`, `intr`, `noip`, `calTyp`, `calPer`, `lnSts`, `disbSts`, `prFeeSts`, `acbal`, `guarantoName`, `guarantorNID`, `relGuarantor`) VALUES
(1, 1, 'Md Shafiqul Alam', 30001, '01732636188', 'ibs/2021/01', '4/27/2021', '4/28/2026', 3995, 1435, 153600, 239700, 60, 9, 0, 'Compound', 'Quarterly', 'C', 'Y', 'Y', 0, 'Md Sajidul Alam', 2147483647, 'Son'),
(2, 2, 'Md Sajidul Alam', 30002, '01680235344', 'ibs/2021/02', '5/2/2021', '5/2/2026', 30625, 5625, 1500000, 1837500, 60, 9, 4, 'Simple', 'Yearly', 'R', 'Y', 'Y', -1715000, 'Md Shafiqul Alam', 2147483647, 'Father'),
(3, 5, 'Md Tanvir Hafiz', 30003, '01682124778', 'ibs/2021/03', '7/10/2021', '7/10/2024', 14289, 4567, 350000, 514404, 36, 9, 3, 'Compound', 'Quarterly', 'R', 'Y', 'Y', -471537, 'Md Sajidul Alam', 2147483647, 'Brother');

-- --------------------------------------------------------

--
-- Table structure for table `tloanassessment`
--

CREATE TABLE `tloanassessment` (
  `id` int(15) NOT NULL,
  `sancno` varchar(30) NOT NULL,
  `custid` int(15) NOT NULL,
  `pamt` int(10) NOT NULL,
  `tscore` int(10) NOT NULL,
  `fassessment` varchar(15) NOT NULL,
  `sancamt` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tloanassessment`
--

INSERT INTO `tloanassessment` (`id`, `sancno`, `custid`, `pamt`, `tscore`, `fassessment`, `sancamt`) VALUES
(1, 'IBS/2021/01', 1, 240000, 64, 'Excellent', 153600),
(2, 'IBS/2021/02', 2, 1500000, 100, 'Excellent', 1500000),
(3, 'IBS/2021/03', 5, 500000, 70, 'Excellent', 350000),
(5, 'IBS/2021/04', 3, 500000, 89, 'Excellent', 445000);

-- --------------------------------------------------------

--
-- Table structure for table `tloantrn`
--

CREATE TABLE `tloantrn` (
  `id` int(11) NOT NULL,
  `batno` int(11) NOT NULL,
  `acno` int(11) NOT NULL,
  `ntcod` int(11) DEFAULT NULL,
  `noi` int(11) DEFAULT NULL,
  `trnamt` double NOT NULL,
  `trndt` varchar(20) NOT NULL,
  `vcno` varchar(20) NOT NULL,
  `trndes` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tloantrn`
--

INSERT INTO `tloantrn` (`id`, `batno`, `acno`, `ntcod`, `noi`, `trnamt`, `trndt`, `vcno`, `trndes`) VALUES
(8, 3007, 30002, 1, 0, 1500, '5/2/2021', '', 'Processing Fee 1500tk for account no. 30002'),
(9, 3008, 30002, 2, 0, 1500000, '5/2/2021', 'v-0225', 'Disbursment of amount 1500000 tk for account no. 3'),
(10, 3009, 30002, 3, 1, 30625, '5/2/2021', 'v-ins', 'Installment for account no. 30002'),
(11, 3010, 30002, 3, 2, 61250, '5/7/2021', 'cash-01', 'Installment for account no. 30002'),
(12, 3011, 30001, 1, 0, 1500, '5/7/2021', '', 'Processing Fee 1500tk for account no. 30001'),
(13, 3012, 30001, 2, 0, 153600, '5/7/2021', 'v-01', 'Disbursment of amount 153600 tk for account no. 30001'),
(14, 3013, 30001, 4, 0, 239700, '5/7/2021', 'vb', 'Settlement for account no. 30001'),
(15, 3014, 30002, 3, 1, 30625, '6/11/2021', 'v-302', 'Installment for account no. 30002'),
(16, 3015, 30003, 1, 0, 1500, '7/10/2021', '', 'Processing Fee 1500tk for account no. 30003'),
(17, 3016, 30003, 2, 0, 350000, '7/10/2021', 'v-2011', 'Disbursment of amount 350000 tk for account no. 30003'),
(18, 3017, 30003, 3, 1, 14289, '7/10/2021', 'v-2001', 'Installment for account no. 30003'),
(19, 3018, 30003, 3, 2, 28578, '7/10/2021', 'v-2121', 'Installment for account no. 30003');

-- --------------------------------------------------------

--
-- Table structure for table `tloan_income`
--

CREATE TABLE `tloan_income` (
  `id` int(11) NOT NULL,
  `batno` int(11) NOT NULL,
  `acno` int(11) NOT NULL,
  `amt` double NOT NULL,
  `year` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tloan_income`
--

INSERT INTO `tloan_income` (`id`, `batno`, `acno`, `amt`, `year`) VALUES
(7, 3007, 30002, 1500, '2021'),
(8, 3009, 30002, 5625, '2021'),
(9, 3010, 30002, 11250, '2021'),
(10, 3011, 30001, 1500, '2021'),
(11, 3013, 30001, 86100, '2021'),
(12, 3014, 30002, 5625, '2021'),
(13, 3015, 30003, 1500, '2021'),
(14, 3017, 30003, 4567, '2021'),
(15, 3018, 30003, 9134, '2021');

-- --------------------------------------------------------

--
-- Table structure for table `tothr_expenditure`
--

CREATE TABLE `tothr_expenditure` (
  `id` int(11) NOT NULL,
  `type` varchar(30) NOT NULL,
  `month` int(11) NOT NULL,
  `year` int(11) NOT NULL,
  `amount` double NOT NULL,
  `batno` int(11) NOT NULL,
  `vcno` varchar(20) NOT NULL,
  `description` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tothr_expenditure`
--

INSERT INTO `tothr_expenditure` (`id`, `type`, `month`, `year`, `amount`, `batno`, `vcno`, `description`) VALUES
(2, 'Salary Expenditure', 6, 2021, 30000, 40001, 'v-80', 'Salary Expenditure'),
(4, 'Miscellaneous Expenditure', 6, 2021, 5000, 40003, 'v-298', 'Miscellaneous Expenditure'),
(5, 'Allowance Expenditure', 6, 2021, 300, 40004, 'v-1212', 'Allowance Expenditure'),
(6, 'Salary Expenditure', 7, 2021, 50000, 40005, 'v-2110', 'Salary Expenditure');

-- --------------------------------------------------------

--
-- Table structure for table `tsavings`
--

CREATE TABLE `tsavings` (
  `id` int(11) NOT NULL,
  `custid` int(11) NOT NULL,
  `actitle` varchar(40) NOT NULL,
  `acno` int(11) NOT NULL,
  `smsmobile` varchar(15) DEFAULT NULL,
  `acbal` double NOT NULL,
  `m_income` double DEFAULT NULL,
  `opendate` varchar(20) DEFAULT NULL,
  `purpose` varchar(30) DEFAULT NULL,
  `f_dep` double DEFAULT NULL,
  `sof` varchar(20) DEFAULT NULL,
  `nominee_name` varchar(40) NOT NULL,
  `nominee_nid` int(20) DEFAULT NULL,
  `relation_nominee` varchar(30) DEFAULT NULL,
  `share_p` varchar(10) DEFAULT NULL,
  `account_status` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tsavings`
--

INSERT INTO `tsavings` (`id`, `custid`, `actitle`, `acno`, `smsmobile`, `acbal`, `m_income`, `opendate`, `purpose`, `f_dep`, `sof`, `nominee_name`, `nominee_nid`, `relation_nominee`, `share_p`, `account_status`) VALUES
(1, 1, 'Md Shafiqul Alam', 1001, '01732636188', 500, 50000, '2/19/2021', 'savings', 500, 'salary', 'Kaniz Rokeya', 2144511021, 'Husband', '80%', 1),
(3, 2, 'Md Sajidul Alam', 1002, '01680235344', 9700, 45000, '2/21/2021', 'Savings', 500, 'Salary', 'Kaniz Rokeya', 25554411, 'Mother', '100%', 1),
(4, 3, 'Kaniz Rokeya', 1003, '01732636188', 200, 0, '5/5/2021', 'Savings', 200, 'Husband Income', 'Md Sajidul Alam', 280295409, 'Son', '100%', 3),
(5, 2, 'Sajidul Shaon', 1004, '01680235344', 3250, 500000, '5/5/2021', 'Savimgs', 1000, 'Salary', '', 0, '', '', 1),
(6, 4, 'Md Biplob Parvez', 1005, '01821114451', 500, 60000, '5/5/2021', 'Savings', 2000, 'Salary and Outsourci', 'Md Rayhan Ali', 2147483647, 'Father', '100%', 1),
(7, 4, 'Md Biplob Parvez', 1006, '01821114451', 750, 50000, '5/7/2021', 'Another Saviigs', 1000, 'Salary', 'Md Sajidul Alam', 2147483647, 'Brither', '', 1),
(8, 2, 'Md Sajidul Alam', 1007, '01680235344', 250, 0, '6/13/2021', '', 0, '', '', 0, '', '', 1),
(9, 5, 'Md Tanvir Hafiz', 1008, '01682124778', 1750, 30000, '7/10/2021', 'Savings', 2000, 'Business', 'Md Sajidul Alam', 2147483647, 'Brother', '100%', 1);

-- --------------------------------------------------------

--
-- Table structure for table `tsavingstrn`
--

CREATE TABLE `tsavingstrn` (
  `id` int(11) NOT NULL,
  `batno` int(11) NOT NULL,
  `acno` int(11) NOT NULL,
  `trntyp` varchar(10) NOT NULL,
  `trnsign` varchar(2) NOT NULL,
  `trnamt` double NOT NULL,
  `trndt` varchar(15) NOT NULL,
  `vcno` varchar(15) NOT NULL,
  `racno` int(11) DEFAULT NULL,
  `trndes` varchar(40) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tsavingstrn`
--

INSERT INTO `tsavingstrn` (`id`, `batno`, `acno`, `trntyp`, `trnsign`, `trnamt`, `trndt`, `vcno`, `racno`, `trndes`) VALUES
(8, 101, 1001, 'Cash', '-', 300, '2/21/2021', 'V-1`', NULL, 'cash out'),
(9, 102, 1002, 'Cash', '+', 2000, '2/21/2021', 'v-2', NULL, 'Cash In'),
(10, 103, 1001, 'Cash', '+', 300, '3/3/2021', 'v-1', NULL, 'cash in'),
(11, 104, 1001, 'Cash', '+', 500, '3/6/2021', 'v-02', NULL, 'description'),
(12, 105, 1001, 'Transfer', '-', 500, '5/5/2021', 'v-01', 1003, 'Transfer'),
(14, 107, 1004, 'Cash', '+', 500, '5/5/2021', 'v511', NULL, 'cah'),
(16, 109, 1002, 'Transfer', '-', 200, '5/5/2021', 'v-76', 1003, 'tfr'),
(17, 110, 1005, 'Cash', '+', 2000, '5/5/2021', 'v-5', NULL, 'First Transaction'),
(18, 111, 1006, 'Cash', '+', 1000, '5/7/2021', 'cash - 01', NULL, 'First deposit'),
(19, 112, 1002, 'Cash', '-', 100000, '6/12/2021', 'v-01', NULL, 'cash withdraw'),
(20, 113, 1007, 'Cash', '+', 500, '6/13/2021', '', NULL, ''),
(21, 114, 1002, 'Cash', '+', 500, '7/10/2021', 'v-01', NULL, 'cash deposit'),
(22, 115, 1002, 'Transfer', '-', 500, '7/10/2021', 'v-02', 1001, 'Transfer amount'),
(23, 116, 1001, 'Cash', '-', 200, '7/10/2021', 'v-01', NULL, 'cash withdraw'),
(24, 117, 1008, 'Cash', '+', 2000, '7/10/2021', 'v-302', NULL, 'First deposit');

-- --------------------------------------------------------

--
-- Table structure for table `tsvacmnfee`
--

CREATE TABLE `tsvacmnfee` (
  `id` int(11) NOT NULL,
  `acno` int(11) NOT NULL,
  `amount` int(11) NOT NULL,
  `year` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tsvacmnfee`
--

INSERT INTO `tsvacmnfee` (`id`, `acno`, `amount`, `year`) VALUES
(14, 1001, 250, 2021),
(15, 1002, 250, 2021),
(16, 1004, 250, 2021),
(17, 1005, 250, 2021),
(18, 1006, 250, 2021),
(19, 1007, 250, 2021),
(20, 1008, 250, 2021),
(21, 1003, 0, 2021);

-- --------------------------------------------------------

--
-- Table structure for table `tuser`
--

CREATE TABLE `tuser` (
  `id` int(11) NOT NULL,
  `fullname` varchar(15) NOT NULL,
  `userid` varchar(15) NOT NULL,
  `pass` varchar(15) NOT NULL,
  `contact` varchar(15) DEFAULT NULL,
  `address` varchar(15) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tuser`
--

INSERT INTO `tuser` (`id`, `fullname`, `userid`, `pass`, `contact`, `address`) VALUES
(1, 'Md Sajidul Alam', 'shaon92', '1992', '01680235344', 'Dhaka');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tcustomer`
--
ALTER TABLE `tcustomer`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `custid` (`custid`);

--
-- Indexes for table `tdeposit`
--
ALTER TABLE `tdeposit`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `acno` (`acno`),
  ADD KEY `Fk_custid_depAc` (`custid`);

--
-- Indexes for table `tdeposittrn`
--
ALTER TABLE `tdeposittrn`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `batno` (`batno`),
  ADD KEY `Fk_AcNoDpTrn` (`acno`);

--
-- Indexes for table `tdep_expenditure`
--
ALTER TABLE `tdep_expenditure`
  ADD PRIMARY KEY (`id`),
  ADD KEY `Fk_BatNoDpTrn` (`batno`);

--
-- Indexes for table `tloan`
--
ALTER TABLE `tloan`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `acno` (`acno`),
  ADD UNIQUE KEY `sancno` (`sancno`),
  ADD KEY `Fk_custid_LoanAc` (`custid`);

--
-- Indexes for table `tloanassessment`
--
ALTER TABLE `tloanassessment`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `sancno` (`sancno`),
  ADD KEY `Fk_custid_LnAs` (`custid`);

--
-- Indexes for table `tloantrn`
--
ALTER TABLE `tloantrn`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `batno` (`batno`),
  ADD KEY `Fk_AcNoLnTrn` (`acno`);

--
-- Indexes for table `tloan_income`
--
ALTER TABLE `tloan_income`
  ADD PRIMARY KEY (`id`),
  ADD KEY `Fk_BatNoLnTrn` (`batno`);

--
-- Indexes for table `tothr_expenditure`
--
ALTER TABLE `tothr_expenditure`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `batno` (`batno`);

--
-- Indexes for table `tsavings`
--
ALTER TABLE `tsavings`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `acno` (`acno`),
  ADD KEY `Fk_custid` (`custid`);

--
-- Indexes for table `tsavingstrn`
--
ALTER TABLE `tsavingstrn`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `batno` (`batno`),
  ADD KEY `Fk_AcNoSvTrn` (`acno`);

--
-- Indexes for table `tsvacmnfee`
--
ALTER TABLE `tsvacmnfee`
  ADD PRIMARY KEY (`id`),
  ADD KEY `Fk_AcNoSvAc` (`acno`);

--
-- Indexes for table `tuser`
--
ALTER TABLE `tuser`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tcustomer`
--
ALTER TABLE `tcustomer`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT for table `tdeposit`
--
ALTER TABLE `tdeposit`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `tdeposittrn`
--
ALTER TABLE `tdeposittrn`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;
--
-- AUTO_INCREMENT for table `tdep_expenditure`
--
ALTER TABLE `tdep_expenditure`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `tloan`
--
ALTER TABLE `tloan`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `tloanassessment`
--
ALTER TABLE `tloanassessment`
  MODIFY `id` int(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT for table `tloantrn`
--
ALTER TABLE `tloantrn`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;
--
-- AUTO_INCREMENT for table `tloan_income`
--
ALTER TABLE `tloan_income`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;
--
-- AUTO_INCREMENT for table `tothr_expenditure`
--
ALTER TABLE `tothr_expenditure`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
--
-- AUTO_INCREMENT for table `tsavings`
--
ALTER TABLE `tsavings`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
--
-- AUTO_INCREMENT for table `tsavingstrn`
--
ALTER TABLE `tsavingstrn`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;
--
-- AUTO_INCREMENT for table `tsvacmnfee`
--
ALTER TABLE `tsvacmnfee`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;
--
-- AUTO_INCREMENT for table `tuser`
--
ALTER TABLE `tuser`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `tdeposit`
--
ALTER TABLE `tdeposit`
  ADD CONSTRAINT `Fk_custid_depAc` FOREIGN KEY (`custid`) REFERENCES `tcustomer` (`custid`);

--
-- Constraints for table `tdeposittrn`
--
ALTER TABLE `tdeposittrn`
  ADD CONSTRAINT `Fk_AcNoDpTrn` FOREIGN KEY (`acno`) REFERENCES `tdeposit` (`acno`);

--
-- Constraints for table `tdep_expenditure`
--
ALTER TABLE `tdep_expenditure`
  ADD CONSTRAINT `Fk_BatNoDpTrn` FOREIGN KEY (`batno`) REFERENCES `tdeposittrn` (`batno`);

--
-- Constraints for table `tloan`
--
ALTER TABLE `tloan`
  ADD CONSTRAINT `Fk_custid_LoanAc` FOREIGN KEY (`custid`) REFERENCES `tcustomer` (`custid`),
  ADD CONSTRAINT `Fk_sanco_LoanSancno` FOREIGN KEY (`sancno`) REFERENCES `tloanassessment` (`sancno`);

--
-- Constraints for table `tloanassessment`
--
ALTER TABLE `tloanassessment`
  ADD CONSTRAINT `Fk_custid_LnAs` FOREIGN KEY (`custid`) REFERENCES `tcustomer` (`custid`);

--
-- Constraints for table `tloantrn`
--
ALTER TABLE `tloantrn`
  ADD CONSTRAINT `Fk_AcNoLnTrn` FOREIGN KEY (`acno`) REFERENCES `tloan` (`acno`);

--
-- Constraints for table `tloan_income`
--
ALTER TABLE `tloan_income`
  ADD CONSTRAINT `Fk_BatNoLnTrn` FOREIGN KEY (`batno`) REFERENCES `tloantrn` (`batno`);

--
-- Constraints for table `tsavings`
--
ALTER TABLE `tsavings`
  ADD CONSTRAINT `Fk_custid` FOREIGN KEY (`custid`) REFERENCES `tcustomer` (`custid`);

--
-- Constraints for table `tsavingstrn`
--
ALTER TABLE `tsavingstrn`
  ADD CONSTRAINT `Fk_AcNoSvTrn` FOREIGN KEY (`acno`) REFERENCES `tsavings` (`acno`);

--
-- Constraints for table `tsvacmnfee`
--
ALTER TABLE `tsvacmnfee`
  ADD CONSTRAINT `Fk_AcNoSvAc` FOREIGN KEY (`acno`) REFERENCES `tsavings` (`acno`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
