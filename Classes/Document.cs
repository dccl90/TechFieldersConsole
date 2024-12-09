namespace TechFielders
{
    public class Document
    {
        /// <summary>
        /// The datbase identifier for the document
        /// </summary>
        private int _id;
        public int DocumentID
        {
            get { return _id; }
        }

        /// <summary>
        /// The name of the document
        /// </summary>
        private string _name;

        public string FileName
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// The path to the document location
        /// </summary>
        private string _path;

        public string Path
        {
            get { return _path; }
            set { _path = value; }
        }

        /// <summary>
        /// The document status which determines if it has been verified
        /// </summary>
        private DocumentStatus _documentStatus;

        public DocumentStatus DocumentStatus
        {
            get { return _documentStatus; }
            set { _documentStatus = value; }
        }

        /// <summary>
        /// The type of document which can either be a qualification or identifiaction document
        /// </summary>
        private DocumentType _documentType;

        public DocumentType DocumentType
        {
            get { return _documentType; }
            set { _documentType = value; }
        }

        /// <summary>
        /// The user who created this document
        /// </summary>
        private User _owner;

        public User Owner
        {
            get { return _owner; }
            set { _owner = value; }
        }
        
        public Document(int id)
        {
            _id = id;
        }
        
    }
}


