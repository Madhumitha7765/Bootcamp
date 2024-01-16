from __future__ import annotations 

from datetime import datetime
from typing import List
from abc import ABC, abstractmethod

class IConverter(ABC):
    @abstractmethod
    def convert(self, document_part: "DocumentPart") -> str:
        pass

class HTMLConverter(IConverter):
    def convert(self, document_part: "DocumentPart") -> str:
        return document_part.accept(self)

    def convert_paragraph(self, paragraph: "Paragraph") -> str:
        return f"<p>{paragraph.content}</p>"

    def convert_hyperlink(self, hyperlink: "Hyperlink") -> str:
        return f'<a href="{hyperlink.url}">{hyperlink.content}</a>'

    def convert_header(self, header: "Header") -> str:
        return f"<h{header.level}>{header.content}</h{header.level}>"

    def convert_footer(self, footer: "Footer") -> str:
        return f"<footer>{footer.content} ({footer.text})</footer>"

class DocumentPart(ABC):
    def __init__(self, content: str):
        self.content = content

    @abstractmethod
    def display(self):
        pass

    @abstractmethod
    def save(self):
        pass

    @abstractmethod
    def accept(self, converter: IConverter) -> str:
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
        with open("document.html", "w") as file:
            file.write("<html>\n<head>\n<title>")
            file.write(f"{self.title}</title>\n</head>\n<body>\n")
            for docpart in self.parts:
                file.write(docpart.accept(HTMLConverter()))
                file.write("\n")
            file.write("</body>\n</html>")

    def display_converted_html_content(self):
        converted_content = self.convert_to_html()
        print("Converted HTML Content:\n", converted_content)

    def convert_to_html(self) -> str:
        converter = HTMLConverter()
        html_content = ""
        for docpart in self.parts:
            html_content += docpart.accept(converter) + "\n"
        return html_content

class Paragraph(DocumentPart):
    def __init__(self, content: str):
        super().__init__(content)

    def display(self):
        print(f"Paragraph: {self.content}")

    def save(self):
        pass

    def accept(self, converter: IConverter) -> str:
        return converter.convert_paragraph(self)

class Hyperlink(DocumentPart):
    def __init__(self, content: str, url: str):
        super().__init__(content)
        self.url = url

    def display(self):
        print(f"Hyperlink: {self.content} ({self.url})")

    def save(self):
        pass

    def accept(self, converter: IConverter) -> str:
        return converter.convert_hyperlink(self)

class Header(DocumentPart):
    def __init__(self, content: str, level: int):
        super().__init__(content)
        self.level = level

    def display(self):
        print(f"Header: {self.content} ({self.level})")

    def save(self):
        pass

    def accept(self, converter: IConverter) -> str:
        return converter.convert_header(self)

class Footer(DocumentPart):
    def __init__(self, content: str, text: str):
        super().__init__(content)
        self.text = text

    def display(self):
        print(f"Footer: {self.content} ({self.text})")

    def save(self):
        pass

    def accept(self, converter: IConverter) -> str:
        return converter.convert_footer(self)

def main():
    doc = Document(title="Sample Document", author="John Doe", date=datetime.now())
    doc.parts.append(Paragraph(content="This is a paragraph."))
    doc.parts.append(Hyperlink(content="Click here", url="https://example.com"))
    doc.parts.append(Header(content="Section 1", level=1))
    doc.parts.append(Footer(content="Footer content", text="Page 1"))

    doc.display_document_content()
    doc.save_document_content()
    doc.display_converted_html_content()

if __name__ == "__main__":
    main()
