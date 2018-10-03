# IFN647
Information Retrieval

## TO-DO
### ~~1. Display final query after processing. (input: string - user query, output: string - final query).~~
### ~~2. Multi-term processing (User will have the option to choose yes or no, input: bool value, if statement to choose different analyser).~~
### ~~3. Insert TIME for seaching and indexing.~~
### ~~4. Present top 10 relevant documents with 
    ####  The title;
    ####  The author/s;
    ####  Bibliographic information (journal abbreviation, volume/number, year of
          publication, page number);
    ####  The first sentence of the abstract. Note: This does not mean the title (which is an
          error) but rather the first genuine line of the abstract. For example for document
          1.txt this would be the line that starts “an experimental study of a wing in…”. 
### 5. Browse results (a method: each time the method is called, then the index of result list +1/-1)
### 6. Retrieve results (a method that display the content of one document (input: document name(string), ouput: content(string))).~~


## DONE
### 1. Indexing.
### 2. Searching.
### 3. Basic ranking of documents.
### 4. Display number of relevant documents.


## GUI
### Task 1: Index
Two directory Path
	Source:  the source collection
		Directory Input
		Button for choosing directory
	Lucene Index: location where index will be built
		Directory Input
		Button for choosing directory
Button for creating the index
A pop-up window for indicating the indexing time

### Task 2: Search
Search box
	Input query
	Input toggle: multi-term/multi-phrase option
Display final query created
Indicate time for searching the index (including the time required for query creation)
Display the number of total results

### Task 3: Browse Results
A ranked list of the top 10 relevant documents
	The title
	The author
	Bibliographic information
	The first sentence of the abstract
Button for moving backwards and forwards through the ranked list of result (10 at a time)

### Task 4: Retrieve Results
Button for showing the entire abstract

### Task 5: Save Results
Input of the file name to save the result
Input of the query ID (001)
Trec_eval program format
	Topic ID: the query identification as entered by the user (001)
	Q0
	DocID: document id
	Rank: the rank of the file as returned by application
	Score: the relevancy score
	Student_numbers_groupname: student numbers for all members of the group (delimited by underscores) and groupname (e.g. 0123456798_0987654321_ourteam)


Beware:
	1. All parameters are separated by whitespace
	2. Need to be a unix formatted file using dos2unix

### Task6
### Task7
