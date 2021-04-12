using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmguImageStream {
	public class ImageStream : IDisposable {

		public event EventHandler OnNewImage;

		public ImageStream() {

		}

	}
}
