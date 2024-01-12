from datetime import datetime
from typing import List
from abc import ABC, abstractmethod 


class DocumentPart(ABC):
    def __init__(self, content: str):
        self.content = content

    @abstractmethod
    def display(self):
        pass

    @abstractmethod
    def save(self):
        pass

class Document:
    def __init__(self, title: str, author: str, date: datetime):
        self.title = title
        self.author = author
        self.date = date
        self.parts: List[DocumentPart] = []


    def display_document_content(self):
        print("Title : ", self.title)
        print("Author : ", self.author)
        print("Date : ", self.date)
        for docpart in self.parts:
            docpart.display()

    def save_document_content(self):
        with open("document.txt", "w") as file:
            file.write(f"Title : {self.title}\n")
            file.write(f"Author : {self.author}\n")
            file.write(f"Date : {self.date}\n")
            for docpart in self.parts:
                docpart.save()


class Paragraph(DocumentPart):
    def __init__(self, content: str):
        super().__init__(content)
    
    def display(self):
        print(f"Paragraph: {self.content}")

    def save(self):
        pass


class Hyperlink(DocumentPart):
    def __init__(self, content: str, url: str):
        super().__init__(content)
        self.url = url

    def display(self):
        print(f"Hyperlink: {self.content} ({self.url})")

    def save(self):
        pass



class Header(DocumentPart):
    def __init__(self, content: str, level: int):
        super().__init__(content)
        self.level = level

    
    def display(self):
        print(f"Header: {self.content} ({self.level})")

    def save(self):
        pass

class Footer(DocumentPart):
    def __init__(self, content: str, text: str):
        super().__init__(content)
        self.text = text

    def display(self):
        print(f"Footer: {self.content} ({self.text})")

    def save(self):
        pass


def main():

    doc = Document(title="Sample Document", author="John Doe", date=datetime.now())
    doc.parts.append(Paragraph(content="This is a paragraph."))
    doc.parts.append(Hyperlink(content="Click here", url="https://example.com"))
    doc.parts.append(Header(content="Section 1", level=1))
    doc.parts.append(Footer(content="Footer content", text="Page 1"))

    doc.display_document_content()


if __name__ =="__main__":
    main()


