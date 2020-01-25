using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace MathEditor.ViewModel
{
    public class EditorViewModel : INotifyPropertyChanged
    {
        
       
        private bool isQuickAccessSetMode;
        private string mathText= "{-ب + $جذر{ب^2+4 أ ج}}\\{2 أ}";

        private bool isParsedResultAvailable;
        private ObservableCollection<ErrorMessage> errors;
        private ObservableCollection<ErrorMessage> warnings;
        private ObservableCollection<ErrorMessage> infos;

        private int editorLineNumber;
        private int editorColNumber;
        
        private ObservableCollection<char> quickAccessChars;
        private int selectedQuickAccessIndex;

        private bool errorFlag;
        private string errorMessage;
        private int selectedGroupOperatorIndex;
        private int selectedCalculusOperatorIndex;
        private int selectedAlgebraOperatorIndex;
        private int selectedProofOperatorIndex;
        private int selectedRelationalOperatorIndex;
        private int selectedEqualityOperatorIndex;
        private int selectedOverDownScriptIndex;
        private int selectedSpecialSymbolIndex;
        private int insertionIndex;
        private MathStyle style;

        private GeometryDrawing resultImage;
        //private string selectedText;
        //private int selectedTextLength;


        public GeometryDrawing ResultImage
        {
            set
            {
                resultImage = value;
                this.OnPropertyChanged("ResultImage");
            }
            get
            {
                return resultImage;
            }
        }

        public MathStyle Style
        {
            set
            {
                style = value;
                OnPropertyChanged("Style");
            }
            get
            {
                return style;
            }
        }

        

        //private Color mathColor, backgroundColor;

        //public Color MathColor
        //{
        //    set
        //    {
        //        mathColor = value;
        //        BrushConverter bc;
                
        //        //Style.FontColor;
        //        OnPropertyChanged("MathColor");
        //    }
        //    get
        //    {
        //        return mathColor;
        //    }
        //}

        //public Color BackgroundColor
        //{
        //    set;
        //    get;
        //}
        public event PropertyChangedEventHandler PropertyChanged;
        public bool IsQuickAccessSetMode
        {
            get
            {
                return this.isQuickAccessSetMode;
            }
            set
            {
                if (this.isQuickAccessSetMode != value)
                {
                    this.isQuickAccessSetMode = value;
                    this.OnPropertyChanged("IsQuickAccessSetMode");
                }
            }
        }
        
        
        public ObservableCollection<char> QuickAccessChars
        {
            get
            {
                return this.quickAccessChars;
            }
            set
            {
                if (this.quickAccessChars != value)
                {
                    this.quickAccessChars = value;
                    this.OnPropertyChanged("QuickAccessChars");
                }
            }
        }
        
        public bool ErrorFlag
        {
            get
            {
                return this.errorFlag;
            }
            set
            {
                if (this.errorFlag != value)
                {
                    this.errorFlag = value;
                    this.OnPropertyChanged("ErrorFlag");
                }
            }
        }
        public string ErrorMessage
        {
            get
            {
                return this.errorMessage;
            }
            set
            {
                if (this.errorMessage != value)
                {
                    this.errorMessage = value;
                    this.OnPropertyChanged("ErrorMessage");
                }
            }
        }
        public char[] GroupOperators
        {
            get
            {
                return new char[]
                {
                    '⊂',
                    '⊄',
                    '⊆',
                    '⊈',
                    '⋂',
                    '⋃',
                    '∈',
                    '∉',
                    '∀',
                    '⋁',
                    '∅',
                    '∧',
                    '∨'
                };
            }
        }
        public char[] CalculusOperators
        {
            get
            {
                return new char[]
                {
                    '∏',
                    '∆',
                    '∇',
                    '∂'
                };
            }
        }
        public char[] AlgebraOperators
        {
            get
            {
                return new char[]
                {
                    '⊕',
                    '⊖',
                    '⊗',
                    '⊙',
                    '⊘',
                    '⊚',
                    '⊛',
                    '⊜',
                    '⊝',
                    '士',
                    '∓',
                    '∔',
                    '∘',
                    '∙',
                    '⋆',
                    '⋅',
                    '⋄'
                };
            }
        }
        public char[] ProofOperators
        {
            get
            {
                return new char[]
                {
                    '∴',
                    '∵',
                    '∸',
                    '∝',
                    '⊥',
                    '⊢',
                    '⊣',
                    '⊤',
                    '⊿',
                    '∥',
                    '∦'
                };
            }
        }
        public char[] EqualityOperators
        {
            get
            {
                return new char[]
                {
                    '≅',
                    '≆',
                    '≇',
                    '≈',
                    '≉',
                    '∼',
                    '≁',
                    '≜',
                    '≟',
                    '≠'
                };
            }
        }
        public char[] RelationalOperators
        {
            get
            {
                return new char[]
                {
                    '≥',
                    '≤',
                    '≦',
                    '≧',
                    '≨',
                    '≩',
                    '≪',
                    '≫',
                    '≮',
                    '≯',
                    '≰',
                    '≱',
                    '≲',
                    '≳',
                    '≴',
                    '≵',
                    '≼',
                    '≽'
                };
            }
        }
        public char[] OverDownScripts
        {
            get
            {
                return new char[]
                {
                    '⏜',
                    '⏝',
                    '⏞',
                    '⏟',
                    '⏠',
                    '⏡',
                    '←',
                    '→',
                    '↑',
                    '↓',
                    '↔',
                    '↕',
                    '⇀',
                    '⇁'
                };
            }
        }
        public char[] SpecialSymbols
        {
            get
            {
                return new char[]
                {
                    '∞',
                    '√',
                    '∛',
                    '∜',
                    '⏎',
                    '⌘',
                    '☪',
                    '☽',
                    '⏢'
                };
            }
        }
        public int SelectedGroupOperatorIndex
        {
            get
            {
                return this.selectedGroupOperatorIndex;
            }
            set
            {
                if (this.selectedGroupOperatorIndex != value)
                {
                    this.selectedGroupOperatorIndex = value;
                    this.OnPropertyChanged("SelectedGroupOperatorIndex");
                }
            }
        }
        public int SelectedCalculusOperatorIndex
        {
            get
            {
                return this.selectedCalculusOperatorIndex;
            }
            set
            {
                if (this.selectedCalculusOperatorIndex != value)
                {
                    this.selectedCalculusOperatorIndex = value;
                    this.OnPropertyChanged("SelectedCalculusOperatorIndex");
                }
            }
        }
        public int SelectedAlgebraOperatorIndex
        {
            get
            {
                return this.selectedAlgebraOperatorIndex;
            }
            set
            {
                if (this.selectedAlgebraOperatorIndex != value)
                {
                    this.selectedAlgebraOperatorIndex = value;
                    this.OnPropertyChanged("SelectedAlgebraOperatorIndex");
                }
            }
        }
        public int SelectedProofOperatorIndex
        {
            get
            {
                return this.selectedProofOperatorIndex;
            }
            set
            {
                if (this.selectedProofOperatorIndex != value)
                {
                    this.selectedProofOperatorIndex = value;
                    this.OnPropertyChanged("SelectedProofOperatorIndex");
                }
            }
        }
        public int SelectedEqualityOperatorIndex
        {
            get
            {
                return this.selectedEqualityOperatorIndex;
            }
            set
            {
                if (this.selectedEqualityOperatorIndex != value)
                {
                    this.selectedEqualityOperatorIndex = value;
                    this.OnPropertyChanged("SelectedEqualityOperatorIndex");
                }
            }
        }
        public int SelectedRelationalOperatorIndex
        {
            get
            {
                return this.selectedRelationalOperatorIndex;
            }
            set
            {
                if (this.selectedRelationalOperatorIndex != value)
                {
                    this.selectedRelationalOperatorIndex = value;
                    this.OnPropertyChanged("SelectedRelationalOperatorIndex");
                }
            }
        }
        public int SelectedOverDownScriptIndex
        {
            get
            {
                return this.selectedOverDownScriptIndex;
            }
            set
            {
                if (this.selectedRelationalOperatorIndex != value)
                {
                    this.selectedOverDownScriptIndex = value;
                    this.OnPropertyChanged("SelectedOverDownScriptIndex");
                }
            }
        }
        public int SelectedSpecialSymbolIndex
        {
            get
            {
                return this.selectedSpecialSymbolIndex;
            }
            set
            {
                if (this.selectedSpecialSymbolIndex != value)
                {
                    this.selectedSpecialSymbolIndex = value;
                    this.OnPropertyChanged("SelectedSpecialSymbolIndex");
                }
            }
        }
        public int SelectedQuickAccessIndex
        {
            get
            {
                return this.selectedQuickAccessIndex;
            }
            set
            {
                if (this.selectedQuickAccessIndex != value)
                {
                    this.selectedQuickAccessIndex = value;
                    this.OnPropertyChanged("SelectedQuickAccessIndex");
                }
            }
        }
        public string MathText
        {
            get
            {
                return this.mathText;
            }
            set
            {
                if (this.mathText != value)
                {
                    this.mathText = value;
                    this.OnPropertyChanged("MathText");
                }
            }
        }
        
        public bool IsParsedResultAvailable
        {
            get
            {
                return this.isParsedResultAvailable;
            }
            set
            {
                if (this.isParsedResultAvailable != value)
                {
                    this.isParsedResultAvailable = value;
                    this.OnPropertyChanged("IsParsedResultAvailable");
                }
            }
        }
        
        public int EditorLineNumber
        {
            get
            {
                return this.editorLineNumber;
            }
            set
            {
                if (this.editorLineNumber != value)
                {
                    this.editorLineNumber = value;
                    this.OnPropertyChanged("EditorLineNumber");
                }
            }
        }
        public int EditorColNumber
        {
            get
            {
                return this.editorColNumber;
            }
            set
            {
                if (this.editorColNumber != value)
                {
                    this.editorColNumber = value;
                    this.OnPropertyChanged("EditorColNumber");
                }
            }
        }
        public ObservableCollection<ErrorMessage> Errors
        {
            get
            {
                return this.errors;
            }
            set
            {
                if (this.errors != value)
                {
                    this.errors = value;
                    this.OnPropertyChanged("Errors");
                }
            }
        }
        public ObservableCollection<ErrorMessage> Warnings
        {
            get
            {
                return this.warnings;
            }
            set
            {
                if (this.warnings != value)
                {
                    this.warnings = value;
                    this.OnPropertyChanged("Warnings");
                }
            }
        }
        public ObservableCollection<ErrorMessage> Infos
        {
            get
            {
                return this.infos;
            }
            set
            {
                if (this.infos != value)
                {
                    this.infos = value;
                    this.OnPropertyChanged("Infos");
                }
            }
        }
        
        public int InsertionIndex
        {
            get
            {
                return this.insertionIndex;
            }
            set
            {
                this.insertionIndex = value;
                this.OnPropertyChanged("InsertionIndex");
            }
        }
        //public int SelectedTextLength
        //{
        //    get
        //    {
        //        return this.selectedTextLength;
        //    }
        //    set
        //    {
        //        this.selectedTextLength = value;
        //        this.OnPropertyChanged("SelectedTextLength");
        //    }
        //}
        public EditorViewModel()
        {
            Style = new MathStyle();
            this.IsParsedResultAvailable = false;
            
            this.Errors = new ObservableCollection<ErrorMessage>();
            this.Warnings = new ObservableCollection<ErrorMessage>();
            this.Infos = new ObservableCollection<ErrorMessage>();
            this.QuickAccessChars = new ObservableCollection<char>(new char[]
            {
                '∈',
                '∇',
                '⊕',
                '∵',
                '∴',
                '∝',
                '∓',
                '≅',
                '≥',
                '∞',
                '∏',
                '⊥'
            });
        }
        protected void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        
        
        
        public void ParseText()
        {
            ListBox x;



            this.Errors.Clear();
            this.Warnings.Clear();
            this.Infos.Clear();

            Interpreter i = new Interpreter();

            i.Style = Style;
            i.SourceText = this.MathText;
            i.Interpret();
            this.Errors = new ObservableCollection<ErrorMessage>(i.Errors);
            this.Warnings = new ObservableCollection<ErrorMessage>(i.Warnings);
            this.Infos = new ObservableCollection<ErrorMessage>(i.Infos);
            this.ErrorFlag = i.Errors.Count > 0;

            if (this.ErrorFlag == false)
                this.ResultImage = i.Image;

        }
        
        public void InsertGroupOperator()
        {
            if (this.IsQuickAccessSetMode)
            {
                this.QuickAccessChars.Add(this.GroupOperators[this.SelectedGroupOperatorIndex]);
                return;
            }
            MathText = MathText.Insert(InsertionIndex, "" + GroupOperators[this.SelectedGroupOperatorIndex]);

           
        }
        public void InsertCalculusOperator()
        {
            if (this.IsQuickAccessSetMode)
            {
                this.QuickAccessChars.Add(this.CalculusOperators[this.SelectedCalculusOperatorIndex]);
                return;
            }
            MathText = MathText.Insert(InsertionIndex, "" + CalculusOperators[this.SelectedCalculusOperatorIndex]);
            
        }
        public void InsertAlgebraOperator()
        {
            if (this.IsQuickAccessSetMode)
            {
                this.QuickAccessChars.Add(this.AlgebraOperators[this.SelectedAlgebraOperatorIndex]);
                return;
            }
            MathText = MathText.Insert(InsertionIndex, "" + AlgebraOperators[this.SelectedAlgebraOperatorIndex]);
            
        }
        public void InsertProofOperator()
        {
            if (this.IsQuickAccessSetMode)
            {
                this.QuickAccessChars.Add(this.ProofOperators[this.SelectedProofOperatorIndex]);
                return;
            }
            MathText=MathText.Insert(InsertionIndex, "" + ProofOperators[this.SelectedProofOperatorIndex]);
            
        }
        public void InsertRelationalOperator()
        {
            if (this.IsQuickAccessSetMode)
            {
                this.QuickAccessChars.Add(this.RelationalOperators[this.SelectedRelationalOperatorIndex]);
                return;
            }
            MathText = MathText.Insert(InsertionIndex, "" + RelationalOperators[this.SelectedRelationalOperatorIndex]);
            
        }
        public void InsertEqualityOperator()
        {
            if (this.IsQuickAccessSetMode)
            {
                this.QuickAccessChars.Add(this.EqualityOperators[this.SelectedEqualityOperatorIndex]);
                return;
            }

            MathText = MathText.Insert(InsertionIndex, "" + this.EqualityOperators[this.SelectedEqualityOperatorIndex]);
            
        }
        public void InsertOverDownScript()
        {
            if (this.IsQuickAccessSetMode)
            {
                this.QuickAccessChars.Add(this.OverDownScripts[this.SelectedOverDownScriptIndex]);
                return;
            }
            MathText = MathText.Insert(InsertionIndex, "" + this.OverDownScripts[this.SelectedOverDownScriptIndex]);
            
        }
        public void InsertSpecialSymbol()
        {
            if (this.IsQuickAccessSetMode)
            {
                this.QuickAccessChars.Add(this.SpecialSymbols[this.SelectedSpecialSymbolIndex]);
                return;
            }
            MathText = MathText.Insert(InsertionIndex, "" + this.SpecialSymbols[this.SelectedSpecialSymbolIndex]);
            
        }
        public void InsertQuickAccessChar()
        {
            MathText = MathText.Insert(InsertionIndex, "" + this.QuickAccessChars[this.SelectedQuickAccessIndex]);
            
        }
        public void RemoveQuickAccessChar()
        {
            this.QuickAccessChars.RemoveAt(this.SelectedQuickAccessIndex);
        }
    }
}
