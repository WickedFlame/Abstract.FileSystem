# Abstract.FileSystem
All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](http://keepachangelog.com/)
and this project adheres to [Semantic Versioning](http://semver.org/).

## v1.0.6
### Fixed
- Fixed namespace for extensions

### Changed
- Updated to .Net8.0

## v1.0.5
### Added
- String extension for IsAbslolutePath
- SystemPath extension for RemoveLeadingSlash
- SystemPath extension for RemoveTrailingSlash

## v1.0.4
### Fixed
- SystemPath.Combine removes leading and trainling slash before combining paths

## v1.0.3
### Fixed
- SystemPath.Combine accepts null as leading SystemPath parameter

## v1.0.2
### Added
- Added string Extensions for RemoveLeadingSlash and RemoveTrailingSlash
- Added string Extensions for EnsureLeadingSlash and EnsureTrailingSlash
- Enumeration for Separators

## v1.0.1
### Fixed
- Fixed XML Documentation

## v1.0.0
### Added
- Abstraction for System.IO.File
- Abstraction for System.IO.Directory
- Abstraction for System.IO.Path